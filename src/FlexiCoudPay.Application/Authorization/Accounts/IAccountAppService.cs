using System.Threading.Tasks;
using Abp.Application.Services;
using FlexiCoudPay.Authorization.Accounts.Dto;

namespace FlexiCoudPay.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
