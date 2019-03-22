using System.Threading.Tasks;
using Abp.Application.Services;
using RealEstateApp.Authorization.Accounts.Dto;

namespace RealEstateApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
