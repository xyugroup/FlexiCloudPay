using Abp.Application.Services;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexiCoudPay.Entities;
using FlexiCoudPay.Respository;

namespace FlexiCoudPay.Payroll
{
    public class CalPayAppService:ApplicationService, ICalPayAppService
    {
        //private readonly IEmployeeRepository _employeeRepository;

        //public CalPayAppService (IEmployeeRepository employeeRepository)
        //{
        //    _employeeRepository = employeeRepository;
        //}   

        public async Task<decimal> CalculatePayroll(string sPeriod, int iCycle, string sEmpNo)
        {
            decimal dBasic = 5000;
            decimal dWorkDay = 0;
            decimal dDayWork = 0;

            bool bInc = false;
            bool bNew = false;

            decimal dCalBasic = calBasic(dBasic,bNew,bInc,dWorkDay,dDayWork);
            return await Task.FromResult(dCalBasic);
        }

        public decimal calBasic(decimal dBasic,bool bNew, bool bInc, decimal dWorkday, decimal dDayWork)
        {
            Decimal dCalBasic = 0;

            dCalBasic = dBasic;

            if (bInc)
            {

            }

            if (bNew)
            {

            }

            dCalBasic = dBasic;
            return dBasic;
        }

        //public async Task<Employee> GetEmployeeById(int id)
        //{
        //    return await _employeeRepository.GetAsync(id);

        //}
    }
}
