using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisciplesMerger.DAL
{
    public class Synclogs
    {
        public int id { get; set; }
        public string timestamp { get; set; }
        public string fk_churches_guid { get; set; }
        public string tablename { get; set; }
        public string fk_guid { get; set; }
        public string action { get; set; }
    }
}
