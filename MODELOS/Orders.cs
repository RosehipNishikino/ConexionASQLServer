using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELOS
{
    public class Orders
    {
        public int OrderID { get; set; }
        public char CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderQuantity { get; set; }
        public Orders() { }
    }
}
