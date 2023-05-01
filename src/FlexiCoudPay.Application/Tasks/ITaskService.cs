using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexiCoudPay.Tasks.Dtos;
using Abp.Application.Services;

namespace FlexiCoudPay.Tasks
{
    public interface ITaskService : IApplicationService
    {
        Task<ListResultDto<TaskDto>> GetAllById(GetAllInput input);
    }
}
