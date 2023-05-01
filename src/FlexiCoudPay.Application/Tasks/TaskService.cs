using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using FlexiCoudPay.Tasks.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Abp.Domain.Services;
using Abp.EntityFrameworkCore;
using Abp.EntityFramework;
using FlexiCoudPay.Tasks;

using Abp.Linq.Extensions;

namespace FlexiCoudPay.Tasks
{
    public class TaskService: FlexiCoudPayAppServiceBase, ITaskService
    {
        private readonly IRepository<Task> _taskRepository;

        public TaskService(IRepository<Task> taskRepository)
        {
            _taskRepository = taskRepository; 

        }

        public async Task<ListResultDto<TaskDto>> GetAllById(GetAllInput input)
        {
            var tasks = await _taskRepository
                .GetAll()
                .WhereIf(true, t => t.Id == input.Id)
                .OrderByDescending(t => t.Id)
                .ToListAsync();


            

            return new ListResultDto<TaskDto>
            (
                ObjectMapper.Map<List<TaskDto>>(tasks)
            );
                                
        }



    }
}
