using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RealEstateApp.Roles.Dto;
using RealEstateApp.Users.Dto;

namespace RealEstateApp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
