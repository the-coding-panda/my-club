using System.Collections.Generic;
using MyClub.Roles.Dto;

namespace MyClub.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
