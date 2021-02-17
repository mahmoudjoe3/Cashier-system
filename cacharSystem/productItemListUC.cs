using cacharSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cacharSystem
{
    public partial class UC_productItemList : UserControl
    {
        int productId = 0;
        Dbcontext db = new Dbcontext();
        public UC_productItemList()
        {
            InitializeComponent();
        }
        public void setId(int id)
        {
            this.productId = id;
        }
        public void setTitle(String title)
        {
            item_title.Text = title;
        }
        public void setImage(byte[] img)
        {
            item_image.Image = Image.FromStream(new MemoryStream(img));
        }
        public void setSellPrice(float sellPrice)
        {
            item_sellPrice.Text = sellPrice+" EGP";
        }
        public void setFactoryPrice(float FactoryPrice)
        {
            item_factoryPrice.Text = FactoryPrice+" EGP";
        }
        public void setQuantity(int quantity)
        {
            item_Quantity.Text = quantity + "";
        }

        private void UC_productItemList_Load(object sender, EventArgs e)
        {

        }

        /*private void item_increase_Click(object sender, EventArgs e)
        {
            quantity++;
            item_quantity.Text = quantity + "";
        }*/

        /*private void item_decrease_Click(object sender, EventArgs e)
        {
            if (quantity > 0)
            {
                quantity--;
                item_quantity.Text = quantity + "";
            }
        }*/

        private void order_delete_Click(object sender, EventArgs e)
        {
            var p = db.products.Find(productId);
            db.products.Remove(p);
            db.SaveChanges();
            
            MessageBox.Show("deleted item " + p.title);
            //delete by productId
        }

        private void order_edit_Click(object sender, EventArgs e)
        {
           
            
            editProductForm form = new editProductForm();
            form.setProduct(db.products.Find(productId));
            form.Show();
        }
    }
}
