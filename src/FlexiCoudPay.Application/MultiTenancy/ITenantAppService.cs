using Abp.Application.Services;
using FlexiCoudPay.MultiTenancy.Dto;

namespace FlexiCoudPay.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

