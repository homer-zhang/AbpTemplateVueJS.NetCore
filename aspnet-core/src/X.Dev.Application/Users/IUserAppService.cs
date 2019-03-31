using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using X.Dev.Roles.Dto;
using X.Dev.Users.Dto;

namespace X.Dev.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
