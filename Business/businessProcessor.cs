using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Common.Classes;

namespace Business
{
    public class businessProcessor
    {
        readonly dataCollection _db;

        public businessProcessor()
        {
            _db = new dataCollection();
        }

        public List<Books> Get()
        {
            return _db.Get();
        }
    }
}
