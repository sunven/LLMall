using System.Collections.Generic;
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
    public class CategoryAppService_Tests : LLMallTestBase
    {
        private readonly ICategoryAppService _categoryAppService;

        public CategoryAppService_Tests()
        {
            _categoryAppService = Resolve<ICategoryAppService>();
        }

        [Fact]
        public async Task Add_Test()
        {
            // Act
            var output = await _categoryAppService.Create(new CategoryDto
            {
                Name = "1", PicUrl = "2",
                CategoryList = new List<CategoryDto>
                {
                    new CategoryDto{Name = "11", PicUrl = "22",}
                }
            });
            // Assert
            Assert.NotEqual(0, output.Id);

            //output.Items.Count.ShouldBeGreaterThan(0);
        }
    }
}
