using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using FlexiCoudPay.Customer.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCoudPay.Customer
{
    public class OrderService : AsyncCrudAppService<Order,OrderDto,int>
    {
        private readonly IRepository<Order> _orderrepository;
        private readonly IRepository<Customer> _customerrepository;

        public OrderService(IRepository<Order> orderrepository, IRepository<Customer> customerrepository) : base(orderrepository)
        {
            _orderrepository = orderrepository;
            _customerrepository = customerrepository;
        }


        public async Task<ListResultDto<OrderDto>> GetOrdersByCustomerId(int customerId)
        {
            var orders = await _orderrepository.GetAll()
                        .Where(o => o.CustomerId == customerId)
                        .ToListAsync();

            var customer = await _customerrepository.GetAsync(customerId);

            var orderDtos = ObjectMapper.Map<List<OrderDto>>(orders);
            orderDtos.ForEach(dto => dto.CustomerId = customerId);

            return new ListResultDto<OrderDto>(orderDtos);

        }

    }
}
