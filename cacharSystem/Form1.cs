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
    public partial class Form1 : Form
    {
        List<product> products = new List<product>();
        public  string name ;
        Dbcontext db;
        
        public Form1(string name)
        {
            
            
            InitializeComponent();
            db = new Dbcontext();
            this.name = name;
            initUi();
            label1.Text = name;
        }

        private void initUi()
        {
            productListContainer.Visible = true;
            generateProductList();
            date.Text = getDate();
            GenrateaddProductUC();
            genrateAddCashierContainer();
            genratePropContaner();
            genrateOrderCotainer();
        }

        private String getDate()
        {
            return DateTime.Now.ToString("ddd MMM,dd,yyyy");
        }

        private void addProducts_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
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

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlider.Location = new Point(b.Location.X + 20, b.Location.Y - 26);
            imgSlider.SendToBack();
        }

        private void generateProductList()
        {
            productListContainer.Controls.Clear();
            products = db.products.ToList();
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
            
            UC_productItemList uc = new UC_productItemList();
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
        private void hideContainer()
        {
            addProductContainer.Visible = false;
            productListContainer.Visible = false;
            orderListContainer.Visible = false;
            propContainer.Visible = false;
            AddCashierContainer.Visible = false;
        }
        private void addProducts_Click(object sender, EventArgs e)
        {
            hideContainer();
            addProductContainer.Visible = true;
        }

        private void GenrateaddProductUC()
        {
            //addProductContainer.Controls.Clear();
            addProductUC uc = new addProductUC();
            uc.BringToFront();
            uc.Dock = DockStyle.Fill;
            addProductContainer.Controls.Add(uc);
        }

        private void Home_Click(object sender, EventArgs e)
        {
            generateProductList();
            hideContainer();
            
            productListContainer.Visible = true;
        }

        private void addCashier_Click(object sender, EventArgs e)
        {
            hideContainer();
            AddCashierContainer.Visible = true;  
        }
        private void genrateAddCashierContainer()
        {
            //AddCashierContainer.Controls.Clear();
            registercashierUC uc = new registercashierUC();
            uc.BringToFront();
            uc.Dock = DockStyle.Fill;
            AddCashierContainer.Controls.Add(uc);
        }

        private void prop_Click(object sender, EventArgs e)
        {
            hideContainer();
            propContainer.Visible = true;
        }

        private void genratePropContaner()
        {
            //propContainer.Controls.Clear();
            propUC uc = new propUC();
            uc.BringToFront();
            uc.Dock = DockStyle.Fill;
            propContainer.Controls.Add(uc);
        }

        private void recipt_Click(object sender, EventArgs e)
        {
            hideContainer();
            orderListContainer.Visible = true;
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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void AddCashierContainer_Paint(object sender, PaintEventArgs e)
        {
            products = db.products.ToList();
        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
