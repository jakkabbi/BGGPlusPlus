using System;
using Xunit;

namespace BGGPlusPlus.Domain.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            BGGApiService service = new BGGApiService();
            string response = service.GetBGGApi().Result;



            Assert.NotNull(response);
        }
    }
}
