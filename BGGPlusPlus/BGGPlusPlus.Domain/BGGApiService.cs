using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BGGPlusPlus.Domain
{
    public class BGGApiService
    {
        public async Task<string> GetBGGApi()
        {
            List<int> tempList = new List<int>();
            for (int i = 100000; i < 101160; i++)
                tempList.Add(i);

            var endpoint = $"https://www.boardgamegeek.com/xmlapi2/thing?id={string.Join(",", tempList)}&stats=1";

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
                        return data;
                    }
                }
            }
        }
    }
}
