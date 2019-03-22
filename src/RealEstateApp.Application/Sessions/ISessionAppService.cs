using System.Threading.Tasks;
using Abp.Application.Services;
using RealEstateApp.Sessions.Dto;

namespace RealEstateApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
