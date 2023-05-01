using Abp.Domain.Repositories;
using FlexiCoudPay.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCoudPay.Respository
{
    public interface IEmployeeRepository: IRepository<Employee,int>
    {

    }
}
