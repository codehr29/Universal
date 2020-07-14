using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPromotion.Data;

namespace MPromotion
{
    interface IPromotion
    {
        List<Promotion> GetAll();
        List<CartItems> ApplyPromotion(List<CartItems> cart);
    }
}
