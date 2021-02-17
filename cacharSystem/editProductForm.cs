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
    public partial class editProductForm : Form
    {
        product product;
        Dbcontext db;

    
          
            public editProductForm()
        {
            InitializeComponent();
            db = new Dbcontext();

        }

        private void InitUi()
        {
            name.Text = product.title;
            quantity.Text = product.quantity+"";
            sPrice.Text = product.sellPrice+"";
            fPrice.Text = product.factoryPrice+"";
          //  image.ImageLocation = product.image;
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
            product product1 = new product();
            product1.factoryPrice = (float)Convert.ToDouble(fPrice.Text.ToString());
            product1.sellPrice = (float)Convert.ToDouble(sPrice.Text.ToString());
            product1.quantity = Convert.ToInt32(quantity.Text.ToString());
            product1.title = name.Text.ToString();
            var p = db.products.Find(product.id);
            if (image.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    product1.img = ms.ToArray();
                }
                image.Image.Save("C:\\Users\\islam\\source\\repos\\mahmoudjoe3\\Cashier-system\\cacharSystem\\Images\\" + product1.title);

            }
            else
            {
                product1.img = p.img;
            }
            
            db.products.Remove(p);
            db.SaveChanges();
            db.products.Add(product1);
            db.SaveChanges();
            MessageBox.Show("Product edited Successfully");
        }
    }
}
