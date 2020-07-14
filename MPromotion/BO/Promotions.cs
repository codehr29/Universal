using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPromotion.Data;

namespace MPromotion.BO
{
    public class Promotions: IPromotion
    {
        public List<Promotion> promotion;

        public Promotions()
        {
            promotion = new List<Promotion>();
            
            Promotion p = new Promotion();
            p.Code = "PROMO1";
            p.Description = "3 A's for 130";
            promotion.Add(p);

            p = new Promotion();
            p.Code = "PROMO2";
            p.Description = "2 B's for 45";
            promotion.Add(p);


            p = new Promotion();
            p.Code = "PROMO3";
            p.Description = "C & D for 30";
            promotion.Add(p);

        }

        public List<CartItems> ApplyPromotion(List<CartItems> cart)
        {

            try
            {
                //var sameItems = cart           
                //                .GroupBy(i => i.Item)
                //                .Select(n => new
                //                {
                //                    ItemKey = n.Key,
                //                    ItemCount = n.Count()
                //                }
                //                )
                //                .OrderBy(n => n.ItemKey);
                double qty1 = 0;

                foreach (CartItems c in cart)
                {
                    double qty = 0;
                    double qtym = 0;
                    

                    if (c.Item == 1)
                    {
                        qty = Math.Floor(Convert.ToDouble(c.Qty) / 3);
                        qtym = Math.Floor(Convert.ToDouble(c.Qty) % 3);
                        if (qty > 0)
                            c.TotalPrice = Convert.ToDouble(qty * 130) + (qtym * c.Price);
                    }
                    if (c.Item == 2)
                    {
                        qty = Math.Floor(Convert.ToDouble(c.Qty) / 2);
                        qtym = Math.Floor(Convert.ToDouble(c.Qty) % 2);
                        if (qty > 0)
                            c.TotalPrice = Convert.ToDouble(qty * 45) + (qtym * c.Price);
                    }

                    if ((c.Item == 3) || (c.Item == 4))
                    {
                        
                        if (c.Item == 3)
                           qty1 = c.Qty;

                        if((c.Item == 4) && (qty1 == c.Qty))
                        {
                            c.TotalPrice = Convert.ToDouble(c.Qty * 30);
                            var third = cart.Where(x => x.Item == 3).FirstOrDefault();
                            third.TotalPrice = 0;
                        }
                        else if ((c.Item == 4) && (qty1 != c.Qty))
                        {
                            qty1 = qty1 - c.Qty;
                            c.TotalPrice = Math.Abs(Convert.ToDouble(qty1 * 30));
                            var third = cart.Where(x => x.Item == 3).FirstOrDefault();
                            third.TotalPrice = Math.Abs(qty1 * third.Price);
                        }

                    }
                        
                }

            }
            catch (Exception)
            {

                throw;
            }
            return cart;
        }

        public List<Promotion> GetAll()
        {
            throw new System.NotImplementedException();
        }

    }
}
