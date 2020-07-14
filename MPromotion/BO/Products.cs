using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPromotion.Data;


namespace MPromotion.BO
{
    public class Products
    {
        public List<Product> prod;
        public Products()
        {
            prod = new List<Product>();
        }

        public List<Product> GetProducts()
        {
            
            try
            {

                prod.Clear();
                Product pr = new Product();
                pr.ProdID = 1;
                pr.ProdName = "A";
                pr.ProdPrice = 50;
                prod.Add(pr);

                pr = new Product();
                pr.ProdID = 2;
                pr.ProdName = "B";
                pr.ProdPrice = 30;
                prod.Add(pr);

                pr = new Product();
                pr.ProdID = 3;
                pr.ProdName = "C";
                pr.ProdPrice = 20;
                prod.Add(pr);

                pr = new Product();
                pr.ProdID = 4;
                pr.ProdName = "D";
                pr.ProdPrice = 15;
                prod.Add(pr);
                return prod;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

    }
}
