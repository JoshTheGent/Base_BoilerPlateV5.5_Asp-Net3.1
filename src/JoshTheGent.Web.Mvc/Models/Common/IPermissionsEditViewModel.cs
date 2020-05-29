using System.Collections.Generic;
using JoshTheGent.Roles.Dto;

namespace JoshTheGent.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}