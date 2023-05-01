using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCoudPay.Payroll
{
    public interface ICalPayAppService : IApplicationService
    {
        Task<decimal> CalculatePayroll(string sPeriod, int iCycle, string sEmpNo);
    }
}
