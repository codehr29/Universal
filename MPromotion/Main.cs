using MPromotion.BO;
using MPromotion.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPromotion
{
    public partial class Main : Form
    {
        public Store store;
        public Main()
        {
            InitializeComponent();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                pnlCheckout.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured, try again");   
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                store = new Store();

                dgvProduct.DataSource = store.GetProducts();
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = (Product)dgvProduct.CurrentRow.DataBoundItem;
                dgvCart.DataSource = null;
                dgvCart.DataSource = store.AddItemToCart(p);
                dgvCart.Update();
                dgvCart.Refresh();
                pnlCheckout.Visible = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnApplyPromo_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCart.DataSource = null;
                dgvCart.DataSource = store.ApplyPromotion();
                dgvCart.Update();
                dgvCart.Refresh();
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
