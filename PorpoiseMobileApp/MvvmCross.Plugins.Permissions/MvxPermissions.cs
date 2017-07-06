using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCross.Plugins.Permissions
{
    public class MvxPermissions : IMvxPermissions
    {
        public Task<bool> ShouldShowRequestPermissionRationaleAsync(Permission permission)
        {
            return CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(permission);
        }

        public Task<PermissionStatus> CheckPermissionStatusAsync(Permission permission)
        {
            return CrossPermissions.Current.CheckPermissionStatusAsync(permission);
        }

        public Task<Dictionary<Permission, PermissionStatus>> RequestPermissionsAsync(params Permission[] permissions)
        {
            return CrossPermissions.Current.RequestPermissionsAsync(permissions);
        }
    }
}
