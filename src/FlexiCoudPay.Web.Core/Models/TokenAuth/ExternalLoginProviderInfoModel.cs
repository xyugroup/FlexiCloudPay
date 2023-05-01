using Abp.AutoMapper;
using FlexiCoudPay.Authentication.External;

namespace FlexiCoudPay.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
