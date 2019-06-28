using System;
using System.Collections.Generic;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using LLMall.Authorization;
using LLMall.Mall.Dto;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Abp.Specifications;

namespace LLMall.Mall
{
    //[AbpAuthorize(PermissionNames.Pages_Users)]
    public class CategoryAppService : AsyncCrudAppService<Category, CategoryDto, int,CategorySearchDto>, ICategoryAppService
    {
        public CategoryAppService(IRepository<Category, int> repository) : base(repository)
        {
        }

        public override Task<CategoryDto> Create(CategoryDto input)
        {
            var max = Repository.GetAll().Where(c => c.ParentId == input.ParentId).OrderByDescending(c => c.Code).FirstOrDefault();
            if (max == null)
            {
                input.Code = "01";
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

        protected override IQueryable<Category> CreateFilteredQuery(CategorySearchDto input)
        {
            Expression<Func<Category, bool>> exp=c=>true;
            if (input.ParentId.HasValue)
            {
                exp =exp.And(c => c.ParentId == input.ParentId);
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
