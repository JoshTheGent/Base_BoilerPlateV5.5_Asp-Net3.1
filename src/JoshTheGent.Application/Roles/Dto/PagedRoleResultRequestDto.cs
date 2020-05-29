using Abp.Application.Services.Dto;

namespace JoshTheGent.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

