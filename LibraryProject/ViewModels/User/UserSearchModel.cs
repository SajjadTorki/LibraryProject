using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.User
{
    public class UserSearchModel: BaseModel
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => FirstName + " " + LastName;

        public string UserName { get; set; }
    }
}
