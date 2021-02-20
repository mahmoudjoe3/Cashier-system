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

    public partial class Form2 : Form
    {
        List<product> products = new List<product>();

        public Form2(String code)
        {
            InitializeComponent();
            label1.Text = code;
            initUi();
        }
        private void initUi()
        {
            productListContainer.Visible = true;
            generateProductList();
            date.Text = getDate();
            genrateOrderCotainer();
        }
        private String getDate()
        {
            return DateTime.Now.ToString("ddd MMM,dd,yyyy");
        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlider.Location = new Point(b.Location.X + 20, b.Location.Y - 26);
            imgSlider.SendToBack();
        }

        private void generateProductList()
        {
            productListContainer.Controls.Clear();
            //products = db.products.ToList();
            genrateProductListView();
        }
        private void genrateProductListView()
        {
            productListContainer.Controls.Clear();
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
            int uc_count = productListContainer.Controls.Count;
            if (uc_count != 0)
            {
                uc.Location = new Point(uc.Location.X
                    , uc.Location.Y + (uc_count * uc.Height));
            }
            productListContainer.Controls.Add(uc);
        }

        private void hideContainer()
        {
            orderListContainer.Visible = false;
            productListContainer.Visible = false;
        }
        private void genrateOrderCotainer()
        {
            orderListContainer.Controls.Clear();
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
                int uc_count = orderListContainer.Controls.Count;
                if (uc_count != 0)
                {
                    uc.Location = new Point(uc.Location.X
                        , uc.Location.Y + (uc_count * uc.Height));
                }
                orderListContainer.Controls.Add(uc);
            }
        }
        private void Home_Click(object sender, EventArgs e)
        {
            generateProductList();
            hideContainer();

            productListContainer.Visible = true;
        }

        private void Home_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void recipt_Click(object sender, EventArgs e)
        {
            hideContainer();
            orderListContainer.Visible = true;
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.Show();
            
        }

        private void filter()
        {
            if (search.Text.Trim().Length > 0 && !search.Text.Equals("Search"))
            {
                productListContainer.Controls.Clear();
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
