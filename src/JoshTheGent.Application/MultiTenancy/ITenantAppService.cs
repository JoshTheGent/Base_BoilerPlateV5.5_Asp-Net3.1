using Abp.Application.Services;
using JoshTheGent.MultiTenancy.Dto;

namespace JoshTheGent.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

