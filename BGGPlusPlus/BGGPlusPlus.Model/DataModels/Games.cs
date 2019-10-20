using System;
using System.Collections.Generic;

namespace BGGPlusPlus.Model.DataModels
{
    public partial class Games
    {
        public Games()
        {
            GameArtist = new HashSet<GameArtist>();
            GameCategory = new HashSet<GameCategory>();
            GameDesigner = new HashSet<GameDesigner>();
            GamePublisher = new HashSet<GamePublisher>();
        }

        public int Id { get; set; }
        public string GameName { get; set; }
        public int? MinPlayers { get; set; }
        public int? MaxPlayers { get; set; }
        public int? SugPlayers { get; set; }
        public string GameDesc { get; set; }
        public int? PlaytimeMin { get; set; }
        public int? PlaytimeMax { get; set; }
        public double? ReviewScore { get; set; }
        public int? NumReviews { get; set; }
        public double? Complexity { get; set; }
        public int? AgeMin { get; set; }
        public int? AgeMax { get; set; }

        public virtual ICollection<GameArtist> GameArtist { get; set; }
        public virtual ICollection<GameCategory> GameCategory { get; set; }
        public virtual ICollection<GameDesigner> GameDesigner { get; set; }
        public virtual ICollection<GamePublisher> GamePublisher { get; set; }
    }
}
