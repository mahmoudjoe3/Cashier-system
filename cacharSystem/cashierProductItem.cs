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

    public partial class cashierProductItem : UserControl
    {
        int productId = 0;

        public cashierProductItem()
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
            item_sellPrice.Text = sellPrice + " EGP";
        }
        public void setFactoryPrice(float FactoryPrice)
        {
            item_factoryPrice.Text = FactoryPrice + " EGP";
        }
        public void setQuantity(int quantity)
        {
            item_Quantity.Text = quantity + "";
        }
        private void cashierProductItem_Load(object sender, EventArgs e)
        {

        }

        private void order_edit_Click(object sender, EventArgs e)
        {

        }
    }
}
