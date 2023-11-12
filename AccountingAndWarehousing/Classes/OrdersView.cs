using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingAndWarehousing.Classes
{
    public class OrdersView
    {
        public int ProductID { get; set; }

        public string ProductCodeName { get; set; }

        public int UnitPrice { get; set; }

        public int Quantity { get; set; }

        public int Discount { get; set; }

        public Int64 PriceQuantity
        {
            get
            {
                return (UnitPrice * Quantity);
            }
        }

        public Int64 RowTotalPrice
        {
            get
            {
                return PriceQuantity - Discount;
            }
        }
    }
}
