using System.Collections.Generic;
using JoshTheGent.Roles.Dto;

namespace JoshTheGent.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
