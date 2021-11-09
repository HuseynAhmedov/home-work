using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app
{
    class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; private set; }

        private int _no;
        public int NoMain { get { return _no; }
            private set 
            {
                _no = value;
            }
        }
        private static int _tempNo = 1;
        public Book(string name_, string authorName_ ,int pageCount_)
        {
            NoMain = _tempNo++;
            this.Name = name_;
            this.AuthorName = authorName_;
            this.PageCount = pageCount_;
        }
    }
}
