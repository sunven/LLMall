using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.Specifications;
using LLMall.Mall.Dto;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LLMall.Mall
{
    //[AbpAuthorize(PermissionNames.Pages_Users)]
    public class CategoryAppService : AsyncCrudAppService<Category, CategoryDto, int, CategorySearchDto>, ICategoryAppService
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
                    input.Code = input.ParentCode + "01";
                }
            }
            else
            {
                string strCode;
                if (int.TryParse(max.Code, out var intCode))
                {
                    intCode++;
                    //todo 大于99的判断
                    strCode = "0" + intCode.ToString();
                }
                else
                {
                    strCode = input.ParentCode + "01";
                }
                input.Code = strCode;
            }
            return base.Create(input);
        }

        protected override IQueryable<Category> CreateFilteredQuery(CategorySearchDto input)
        {
            Expression<Func<Category, bool>> exp = c => true;
            if (input.ParentId.HasValue)
            {
                exp = exp.And(c => c.ParentId == input.ParentId);
            }
            return Repository.GetAll().Where(exp);
        }

        protected override IQueryable<Category> ApplySorting(IQueryable<Category> query, CategorySearchDto input)
        {
            //query.OrderBy(input.SortStr);
            return base.ApplySorting(query, input);
        }
    }
}
