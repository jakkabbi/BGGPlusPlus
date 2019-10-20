using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Linq;
using System.IO;
using System.Xml;
using BGGPlusPlus.Model.BGGModels;
using BGGPlusPlus.Model.DataModels;

namespace BGGPlusPlus.Domain
{
    public class BGGApiService
    {
        BGGPlusPlusContext _dbContext;
        public BGGApiService(BGGPlusPlusContext bggPlusPlusContext)
        {
            _dbContext = bggPlusPlusContext;
        }

        public List<string> GetCsvValues()
        {
            using (var reader = new StreamReader(@"..\bggIds.csv"))
            {
                List<string> csvContent = new List<string>();
                while(!reader.EndOfStream)
                {
                    csvContent.Add(reader.ReadLine());
                }
                return csvContent;
            }
        }

        public void FillDatabase(List<string> ids)
        {
            string payload = null;
            for (int i = 0; i < (ids.Count / 1160) + 1; i++)
            {
                payload = String.Join(",", ids.ToArray(), i * 1160, 1160);

                var temp = GetBGGApi(payload).Result;
                Insert(temp);
            }
        }

        private void Insert(List<Item> itemList)
        {
            foreach (Item item in itemList)
            {
                int highestVotes = -1;
                int suggestedPlayers = 0;
                foreach (Results results in item.Poll.Where(poll => poll.Name.Contains("suggested_numplayers")).ToList().First().Results)
                {
                    foreach (Result result in results.Result)
                    {
                        if (result.Value.Contains("Best") && int.Parse(result.Numvotes) > highestVotes)
                        {
                            highestVotes = int.Parse(result.Numvotes);
                            suggestedPlayers = int.Parse(results.Numplayers);
                        }
                    }
                }

                Games game = new Games
                {
                    Id = int.Parse(item.Id),
                    GameName = item.Name.First().Value,
                    MinPlayers = int.Parse(item.Minplayers.Value),
                    MaxPlayers = int.Parse(item.Maxplayers.Value),
                    SugPlayers = suggestedPlayers,
                    GameDesc = item.Description,
                    PlaytimeMin = int.Parse(item.Minplaytime.Value),
                    PlaytimeMax = int.Parse(item.Maxplaytime.Value),
                    ReviewScore = double.Parse(item.Statistics.Ratings.Average.Value),
                    NumReviews = int.Parse(item.Statistics.Ratings.Usersrated.Value),
                    Complexity = double.Parse(item.Statistics.Ratings.Averageweight.Value),
                    AgeMin = int.Parse(item.Minage.Value),
                    AgeMax = 99,
                    PictureUrl = item.Thumbnail
                };

                foreach (Link link in item.Link)
                {
                    if (link.Type.Contains("category"))
                    {
                        Category category = new Category
                        {
                            Id = int.Parse(link.Id),
                            Category1 = link.Value
                        };
                        GameCategory gameCategory = new GameCategory
                        {
                            GameId = game.Id,
                            CategoryId = category.Id
                        };

                        if (!_dbContext.GameCategory.Contains(gameCategory))
                            _dbContext.Add(gameCategory);

                        if (!_dbContext.Category.Contains(category))
                            _dbContext.Add(category);
                    }
                    else if (link.Type.Contains("mechanic"))
                    {
                        Mechanic mechanic = new Mechanic
                        {
                            Id = int.Parse(link.Id),
                            Mechanic1 = link.Value
                        };
                        GameMechanic gameMechanic = new GameMechanic
                        {
                            GameId = game.Id,
                            MechanicId = mechanic.Id
                        };

                        if (!_dbContext.GameMechanic.Contains(gameMechanic))
                            _dbContext.Add(gameMechanic);

                        if (!_dbContext.Mechanic.Contains(mechanic))
                            _dbContext.Add(mechanic);
                    }
                    else if (link.Type.Contains("publish"))
                    {
                        Publisher publisher = new Publisher
                        {
                            Id = int.Parse(link.Id),
                            Publisher1 = link.Value
                        };

                        GamePublisher gamePublisher = new GamePublisher
                        {
                            GameId = game.Id,
                            PublisherId = publisher.Id
                        };
                        if (!_dbContext.GamePublisher.Contains(gamePublisher))
                            _dbContext.Add(gamePublisher);
    
                        if (!_dbContext.Publisher.Contains(publisher))
                            _dbContext.Add(publisher);
                    }
                    else if (link.Type.Contains("design"))
                    {
                        Designer designer = new Designer
                        {
                            Id = int.Parse(link.Id),
                            Designer1 = link.Value
                        };
                        GameDesigner gameDesigner = new GameDesigner
                        {
                            GameId = game.Id,
                            DesignerId = designer.Id
                        };

                        if (!_dbContext.GameDesigner.Contains(gameDesigner))
                            _dbContext.Add(gameDesigner);

                        if (!_dbContext.Designer.Contains(designer))
                            _dbContext.Add(designer);
                    }
                    else if (link.Type.Contains("artist"))
                    {
                        Artist artist = new Artist
                        {
                            Id = int.Parse(link.Id),
                            Artist1 = link.Value
                        };
                        GameArtist gameArtist = new GameArtist
                        {
                            GameId = game.Id,
                            ArtistId = artist.Id
                        };
                        if (!_dbContext.GameArtist.Contains(gameArtist))
                            _dbContext.Add(gameArtist);
                        if (!_dbContext.Artist.Contains(artist))
                            _dbContext.Add(artist);
                    }
                }
                if(!_dbContext.Games.Contains(game))
                    _dbContext.Add(game);
                _dbContext.SaveChanges();
            }
        }

        public async Task<List<Item>> GetBGGApi(string payload)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Items));

            List<int> tempList = new List<int>();

            var endpoint = $"https://www.boardgamegeek.com/xmlapi2/thing?id={payload}&stats=1";

            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));

                using (HttpResponseMessage response = await httpClient.GetAsync(endpoint))
                {
                    using (HttpContent content = response.Content)
                    {
                        var result = await content.ReadAsByteArrayAsync();
                        var data = Encoding.UTF8.GetString(result, 0, result.Length);

                        using (TextReader reader = new StringReader(data))
                        {
                            Items items = (Items)serializer.Deserialize(reader);

                            return items.Item;
                        }
                    }
                }
            }
        }
    }
}
