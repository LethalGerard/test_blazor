using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Classes;

namespace Data
{
    public class dataCollection
    {
        List<Books> bookList = new List<Books>();

        public dataCollection()
        {
            seedData();
        }

        void seedData()
        {
            bookList.Add(new Books(600, "Oliver Twist"));
            bookList.Add(new Books(250, "My book"));
            bookList.Add(new Books(300, "My book pt.2"));
        }

       public List<Books> Get()
        {
            return bookList;
        }
    }
}
