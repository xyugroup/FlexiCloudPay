using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCoudPay.Customer.Dtos
{
    [AutoMapFrom(typeof(Customer))]
    public class CustomerDto : EntityDto<int>
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
