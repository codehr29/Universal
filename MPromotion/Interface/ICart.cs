using MPromotion.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPromotion.Interface
{
    interface ICart
    {
        CartItems AddItem(Product prod);
        void DeleteItem();
        void UpdateItem();

    }
}
