using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.FormBorrow
{
    public class FormBorrowSearchModel:BaseModel
    {
        public string BookName { get; set; }

        public DateTime BorrowDate { get; set; }

        public int NumberofDay { get; set; }
    }
}
