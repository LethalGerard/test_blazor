using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes
{
    public class Books
    {
        public int pages { get; set; }
        public string title { get; set; }

        public Books(int Pages, string Title)
        {
            pages = Pages;
            title = Title;
        }
    }
}
