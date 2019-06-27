using System.Collections.Generic;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using LLMall.Authorization;
using LLMall.Mall.Dto;
using System.Linq;
using System.Threading.Tasks;

namespace LLMall.Mall
{
    //[AbpAuthorize(PermissionNames.Pages_Users)]
    public class CategoryAppService : AsyncCrudAppService<Category, CategoryDto, int>, ICategoryAppService
    {
        public CategoryAppService(IRepository<Category, int> repository) : base(repository)
        {
        }
    }
}
