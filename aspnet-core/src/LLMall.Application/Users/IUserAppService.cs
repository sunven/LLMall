using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LLMall.Roles.Dto;
using LLMall.Users.Dto;

namespace LLMall.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
