using Abp.MultiTenancy;
using FlexiCoudPay.Authorization.Users;

namespace FlexiCoudPay.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
