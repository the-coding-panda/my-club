using System.Collections.Generic;
using MyClub.Roles.Dto;

namespace MyClub.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}