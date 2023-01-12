using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Member
{
    public class MemberSearchModel: BaseModel
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => FirstName + " " + LastName;

        public string MajorName { get; set; }

        public string ProofName { get; set; }

        public DateTime MemberDate { get; set; }
    }
}
