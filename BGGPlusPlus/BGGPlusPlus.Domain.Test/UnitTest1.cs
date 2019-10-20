using System;
using Xunit;
using Moq;
using BGGPlusPlus.Model.DataModels;

namespace BGGPlusPlus.Domain.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            BGGApiService service = new BGGApiService(new Mock<BGGPlusPlusContext>().Object);
            var response = service.GetBGGApi("1").Result;

            Assert.NotNull(response);
        }
    }
}
