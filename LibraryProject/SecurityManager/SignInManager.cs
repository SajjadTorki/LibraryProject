using Core;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SecurityManager
{
    public static class SignInManager
    {
       public static User OnlineUser { get; set; }

        public static void Authenticate(string userName,string password)
        {
            password = password.Hash();
            OnlineUser = DataBase.Context.Users.SingleOrDefault(p => p.UserName == userName
              && p.Password == password );
            if(OnlineUser==null)
            {
                throw new AuthenticateException();
            }
            else
            {
                OnlineUser.LastLoginTime = DateTime.Now;
                //DataBase.Context.SaveChanges();
            }

        }
    }
}
