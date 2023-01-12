
using Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public static class DataBase
    {
        private static LibraryContext _context = new LibraryContext();
        public static LibraryContext Context
        {
            get=> _context;
            
        }
    }
}
