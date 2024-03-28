using Abp.Application.Services;
using DemoVineForce.MultiTenancy.Dto;

namespace DemoVineForce.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

