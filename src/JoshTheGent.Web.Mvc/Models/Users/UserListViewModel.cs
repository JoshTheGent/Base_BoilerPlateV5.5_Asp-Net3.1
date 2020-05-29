using System.Collections.Generic;
using JoshTheGent.Roles.Dto;

namespace JoshTheGent.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
