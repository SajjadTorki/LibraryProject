using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurityManager
{
    public static class AuthorizeManager
    {
        public static void Authorize(UserActivity userActivity)
        {
            var _list = SignInManager.OnlineUser.Roles.ToList();
            if (_list.Any(p => p.RoleName.ToLower() == "administrator"))
            {
                return;
            }

            if(!_list.Any(p=>p.Activities.Any(act=>act.ActivityName==userActivity)))
            {
                throw new AuthorizationException();
            }
        }
    }
}
