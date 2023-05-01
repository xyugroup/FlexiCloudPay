using System.Threading.Tasks;
using Abp.Application.Services;
using FlexiCoudPay.Sessions.Dto;

namespace FlexiCoudPay.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
