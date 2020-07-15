using System.Collections.Generic;
using MyClub.Roles.Dto;

namespace MyClub.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
