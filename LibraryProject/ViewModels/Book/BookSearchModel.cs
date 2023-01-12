using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Book
{
    public class BookSearchModel: BaseModel
    {
      
        public string BookName { get; set; }
        public string ISBN { get; set; }
        public string Writers { get; set; }
        public string SubjectName { get; set; }
    }
}
