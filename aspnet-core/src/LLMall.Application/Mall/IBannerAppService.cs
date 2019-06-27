using Abp.Application.Services;
using LLMall.Mall.Dto;
using System.Threading.Tasks;

namespace LLMall.Mall
{
    public interface IBannerAppService : IAsyncCrudAppService<BannerDto, int, BannerSearchDto>
    {
        Task<Banner> Add(BannerDto dto);
    }
}
