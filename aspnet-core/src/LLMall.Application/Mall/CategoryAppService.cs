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

        public override Task<CategoryDto> Create(CategoryDto input)
        {
            var max = Repository.GetAll().Where(c => c.ParentId == input.ParentId).OrderByDescending(c => c.Code).FirstOrDefault();
            if (max == null)
            {
                if (input.ParentId == 0)
                {
                    input.Code = "01";
                }
                else
                {
                    input.Code = max.Code + "01";
                }
            }
            else
            {
                string strCode;
                if (int.TryParse(max.Code, out var intCode))
                {
                    intCode++;
                    strCode = intCode > 9 ? "" : "0" + intCode.ToString();
                }
                else
                {
                    strCode = "01";
                }
                if (input.ParentId == 0)
                {
                    input.Code = strCode;
                }
                else
                {
                    input.Code = max.Code + strCode;
                }
            }
            return base.Create(input);
        }
    }
}
