using cacharSystem.Model;
using Guna.UI2.WinForms;
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
    public partial class casheirForm : Form
    {
        List<product> products = new List<product>();

        public casheirForm(String code)
        {
            InitializeComponent();
            label1.Text = code;

            initUi();
        }

        private void casheirForm_Load(object sender, EventArgs e)
        {

        }
        private void initUi()
        {
            productContainer.Visible = true;
            generateProductList();
            date.Text = getDate();
            genrateOrderCotainer();
        }
        private String getDate()
        {
            return DateTime.Now.ToString("ddd MMM,dd,yyyy");
        }

        private void Home_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }
        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlider.Location = new Point(b.Location.X + 20, b.Location.Y - 26);
            imgSlider.SendToBack();
        }
        private void generateProductList()
        {
            productContainer.Controls.Clear();
            //products = db.products.ToList();
            genrateProductListView();
        }
        private void genrateProductListView()
        {
            productContainer.Controls.Clear();
            foreach (product p in products)
            {
                addUserControl(p);
            }
        }
        private void addUserControl(product p)
        {

            cashierProductItem uc = new cashierProductItem();
            uc.BringToFront();
            uc.setTitle(p.title);
            uc.setImage(p.img);
            uc.setQuantity(p.quantity);
            uc.setSellPrice(p.sellPrice);
            uc.setFactoryPrice(p.factoryPrice);
            uc.setId(p.id);
            int uc_count = productContainer.Controls.Count;
            if (uc_count != 0)
            {
                uc.Location = new Point(uc.Location.X
                    , uc.Location.Y + (uc_count * uc.Height));
            }
            productContainer.Controls.Add(uc);
        }
        private void hideContainer()
        {
            reciptsContainer.Visible = false;
            productContainer.Visible = false;
        }
        private void genrateOrderCotainer()
        {
            reciptsContainer.Controls.Clear();
            for (int i = 0; i < 12; i++)
            {
                orderUC uc = new orderUC();
                uc.BringToFront();
                /*uc.setTitle(p.title);
                //uc_.setImage(p.image);
                uc.setQuantity(p.quantity);
                uc.setSellPrice(p.sellPrice);
                uc.setFactoryPrice(p.factoryPrice);
                uc.setId(p.id);*/
                int uc_count = reciptsContainer.Controls.Count;
                if (uc_count != 0)
                {
                    uc.Location = new Point(uc.Location.X
                        , uc.Location.Y + (uc_count * uc.Height));
                }
                reciptsContainer.Controls.Add(uc);
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            generateProductList();
            hideContainer();

            productContainer.Visible = true;
        }

        private void recipt_Click(object sender, EventArgs e)
        {
            hideContainer();
            reciptsContainer.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void filter()
        {
            if (search.Text.Trim().Length > 0 && !search.Text.Equals("Search"))
            {
                productContainer.Controls.Clear();
                String searchKey = search.Text;
                foreach (product p in products)
                {
                    if (p.title.Contains(searchKey))
                    {
                        addUserControl(p);
                    }
                }
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            filter();
        }
        private void search_MouseClick(object sender, MouseEventArgs e)
        {
            if (search.Text.Equals("Search"))
                search.Clear();
        }

        private void search_MouseLeave(object sender, EventArgs e)
        {
            if (search.Text.Trim().Length == 0)
                search.Text = "Search";
        }
        private void search_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void addTocart(product p)
        {

            cartItem uc = new cartItem();
            uc.BringToFront();
            uc.setTitle(p.title);
            uc.setSellPrice(p.sellPrice);
            uc.setId(p.id);
            int uc_count = cart.Controls.Count;
            if (uc_count != 0)
            {
                uc.Location = new Point(uc.Location.X
                    , uc.Location.Y + (uc_count * uc.Height));
            }
            cart.Controls.Add(uc);
        }
      
    }
}
