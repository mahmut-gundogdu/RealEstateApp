using System.Collections.Generic;
using RealEstateApp.Roles.Dto;
using RealEstateApp.Users.Dto;

namespace RealEstateApp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
