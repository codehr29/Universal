using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPromotion.Data
{
    public class CartItems
    {
        public int Item { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public bool IsPromotionApplied { get; set; }
    }
}
