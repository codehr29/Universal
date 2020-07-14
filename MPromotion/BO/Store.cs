using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPromotion.Data;

namespace MPromotion.BO
{
    public class Store
    {
        public List<Product> products = new List<Product>();
        public List<CartItems> cart = new List<CartItems>();
        public Store()
        {
            
        }

        public List<Product> GetProducts()
        {
            Products p = new Products();
            products = p.GetProducts();
            return products;
        }

        public List<CartItems> AddItemToCart(Product p)
        {
            if (cart.Any(a => a.Item == p.ProdID))
            {
                var existingItem = cart.Where(x => x.Item == p.ProdID).FirstOrDefault();
                existingItem.Qty += 1;
                existingItem.TotalPrice = existingItem.Qty * p.ProdPrice;
            }
            else
            {
                Cart c = new Cart();
                cart.Add(c.AddItem(p));
            }
            return cart;
        }

        public List<CartItems> ApplyPromotion()
        {
            Promotions pr = new Promotions();
            cart = pr.ApplyPromotion(cart);
            return cart;
        }
    }

}
