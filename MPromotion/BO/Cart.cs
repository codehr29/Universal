using MPromotion.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPromotion.Data;
using System.Runtime.InteropServices.WindowsRuntime;

namespace MPromotion.BO
{
    public class Cart : ICart
    {

        public CartItems AddItem(Product prod)
        {
            CartItems ci = new CartItems();
            try
            {
               
                ci.Item = prod.ProdID;
                ci.Price = prod.ProdPrice;
                ci.Qty = 1;
                ci.TotalPrice = prod.ProdPrice;
                ci.IsPromotionApplied = false;
                

            }
            catch (Exception)
            {

                throw;
            }
            return ci;
        }

        public void DeleteItem()
        {
            throw new NotImplementedException();
        }

     

        public void UpdateItem()
        {
            throw new NotImplementedException();
        }


        
    }
}
