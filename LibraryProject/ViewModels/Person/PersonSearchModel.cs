using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Person
{
    public class PersonSearchModel: BaseModel
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => FirstName + " " + LastName;

        public long NationalCode { get; set; }
    }
}
