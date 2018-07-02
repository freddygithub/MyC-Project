using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class store
    {
        public String Name { get; set; }
        public List<vender> Vendors { get; set; }
        public List<item> Items { get; set; }

        public store()
        {
            Vendors = new List<vender>();
            Items = new List<item>();
        }
    }
}
