using System.Threading.Tasks;
using Abp.Application.Services;
using LLMall.Sessions.Dto;

namespace LLMall.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
