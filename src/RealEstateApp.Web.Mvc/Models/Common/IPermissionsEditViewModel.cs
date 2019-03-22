using System.Collections.Generic;
using RealEstateApp.Roles.Dto;

namespace RealEstateApp.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}