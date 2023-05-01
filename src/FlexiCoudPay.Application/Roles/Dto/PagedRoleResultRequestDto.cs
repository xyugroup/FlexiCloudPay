using Abp.Application.Services.Dto;

namespace FlexiCoudPay.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

