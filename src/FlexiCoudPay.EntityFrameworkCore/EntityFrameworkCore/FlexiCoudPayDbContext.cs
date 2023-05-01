using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FlexiCoudPay.Authorization.Roles;
using FlexiCoudPay.Authorization.Users;
using FlexiCoudPay.MultiTenancy;
using FlexiCoudPay.Tasks;
using FlexiCoudPay.Customer;
//using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace FlexiCoudPay.EntityFrameworkCore
{
    public class FlexiCoudPayDbContext : AbpZeroDbContext<Tenant, Role, User, FlexiCoudPayDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Task> Tasks { get; set; } 

        public DbSet<FlexiCoudPay.Customer.Customer> Customer { get; set; }

        public DbSet<Order> Order { get; set; }

        public FlexiCoudPayDbContext(DbContextOptions<FlexiCoudPayDbContext> options)
            : base(options)
        {
        }
    }
}
