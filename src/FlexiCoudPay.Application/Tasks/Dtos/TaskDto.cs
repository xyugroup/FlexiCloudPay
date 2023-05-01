using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCoudPay.Tasks.Dtos
{
    [AutoMapFrom(typeof(Task))]
    public class TaskDto : EntityDto 
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }


    }
}
