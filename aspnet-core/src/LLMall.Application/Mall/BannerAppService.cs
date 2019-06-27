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
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class BannerAppService : AsyncCrudAppService<Banner, BannerDto, int, BannerSearchDto>, IBannerAppService
    {
        public BannerAppService(IRepository<Banner, int> repository) : base(repository)
        {
        }

        public async Task<Banner> Add(BannerDto dto)
        {
            return await Repository.InsertAsync(MapToEntity(dto));
        }

        protected override IQueryable<Banner> CreateFilteredQuery(BannerSearchDto input)
        {

            return base.CreateFilteredQuery(input);
        }

        //protected override IQueryable<Banner> ApplySorting(IQueryable<Banner> query, BannerSearchDto input)
        //{
        //    return query.OrderBy<(input.SortStr);
        //}
    }
}
