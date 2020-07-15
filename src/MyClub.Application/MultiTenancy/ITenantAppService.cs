using Abp.Application.Services;
using MyClub.MultiTenancy.Dto;

namespace MyClub.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

