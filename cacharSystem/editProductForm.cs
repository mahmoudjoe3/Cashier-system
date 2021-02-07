using cacharSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cacharSystem
{
    public partial class editProductForm : Form
    {
        product product;
        public editProductForm()
        {
            InitializeComponent();
            
        }

        private void InitUi()
        {
            name.Text = product.title;
            quantity.Text = product.quantity+"";
            sPrice.Text = product.sellPrice+"";
            fPrice.Text = product.factoryPrice+"";
            image.ImageLocation = product.image;
        }

        internal void setProduct(product p)
        {
            product = p;
            InitUi();
        }

        private void image_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jbg files(*.jbg)|*.jbg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    image.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            product product = new product(name.Text.ToString()
               , int.Parse(quantity.Text.ToString())
               , float.Parse(sPrice.Text.ToString())
               , float.Parse(fPrice.Text.ToString())
               , image.ImageLocation.ToString());
        }
    }
}
