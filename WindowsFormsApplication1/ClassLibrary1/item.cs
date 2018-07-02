using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }
        public bool PaymentDist { get; set; }
        public vender Owner { get; set; }

        public string Display
        {
            get
            {
                return string.Format("{0} - ${1}", Title, Price);
            }
        }
    }
}
