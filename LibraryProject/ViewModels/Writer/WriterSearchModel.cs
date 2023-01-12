using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Writer
{
    public class WriterSearchModel: BaseModel
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => FirstName + " " + LastName;

        public string Biography { get; set; }
    }
}
