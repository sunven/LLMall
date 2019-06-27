using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using Xunit;
using Abp.Application.Services.Dto;
using LLMall.Users;
using LLMall.Users.Dto;
using LLMall.Mall;
using LLMall.Mall.Dto;

namespace LLMall.Tests.Users
{
    public class BannerAppService_Tests : LLMallTestBase
    {
        private readonly IBannerAppService _bannerAppService;

        public BannerAppService_Tests()
        {
            _bannerAppService = Resolve<IBannerAppService>();
        }

        [Fact]
        public async Task Add_Test()
        {
            // Act
            var output = await _bannerAppService.Add(new BannerDto { Name = "1", PicUrl = "2" });

            // Assert
            Assert.NotEqual(0, output.Id);

            //output.Items.Count.ShouldBeGreaterThan(0);
        }
    }
}
