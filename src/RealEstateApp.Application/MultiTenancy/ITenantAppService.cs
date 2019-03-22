using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RealEstateApp.MultiTenancy.Dto;

namespace RealEstateApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

