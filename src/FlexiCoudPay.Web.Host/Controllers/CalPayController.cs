using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using FlexiCoudPay.Payroll;

namespace FlexiCoudPay.Web.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalPayController : AbpController
    {
        private readonly ICalPayAppService _calPayAppService;

        public CalPayController(ICalPayAppService calPayAppService)
        {
            _calPayAppService = calPayAppService;
        }

        [HttpGet]
        public async Task<decimal> CalculatePay(string sPeriod, int iCycle,string sEmpNo)
        {
            return await _calPayAppService.CalculatePayroll(sPeriod,iCycle ,sEmpNo);
        }


    }
}
