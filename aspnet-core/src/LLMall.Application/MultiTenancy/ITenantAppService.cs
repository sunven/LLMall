using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LLMall.MultiTenancy.Dto;

namespace LLMall.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

