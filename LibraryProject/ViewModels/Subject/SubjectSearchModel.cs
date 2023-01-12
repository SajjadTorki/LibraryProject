using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Subject
{
    public class SubjectSearchModel: BaseModel
    {
        public string SubjectName { get; set; }

        public int BookCount { get; set; }
    }
}
