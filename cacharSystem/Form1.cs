﻿using cacharSystem.Model;
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
        
        public Form1()
        {
            InitializeComponent();
            generateProductList();
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
            panalContainer.Controls.Clear();
            products.Add(new product(1, "tit", 3, 40, 30, "inrfrnfj"));
            products.Add(new product(1, "tit1", 3, 20, 30, "inrfrnfj"));
            products.Add(new product(1, "tit2", 3, 30, 310, "inrfrnfj"));
            products.Add(new product(1, "tit3", 3, 270, 130, "inrfrnfj"));
            products.Add(new product(1, "tit3", 3, 403, 20, "inrfrnfj"));
            products.Add(new product(1, "tit4", 3, 4032, 40, "inrfrnfj"));
            products.Add(new product(1, "tit5", 3, 403, 30, "inrfrnfj"));
            products.Add(new product(1, "tit6", 3, 40, 30, "inrfrnfj"));
            products.Add(new product(1, "tit7", 3, 40, 30, "inrfrnfj"));
            products.Add(new product(1, "tit8", 3, 40, 30, "inrfrnfj"));
            products.Add(new product(1, "tit9", 3, 40, 30, "inrfrnfj"));
            products.Add(new product(1, "tit10", 3, 40, 30, "inrfrnfj"));
            products.Add(new product(1, "tit11", 3, 40, 30, "inrfrnfj"));
            products.Add(new product(1, "tit12", 3, 40, 30, "inrfrnfj"));
            products.Add(new product(1, "tit13", 3, 40, 30, "inrfrnfj"));
            products.Add(new product(1, "tit14", 3, 40, 30, "inrfrnfj"));
            products.Add(new product(1, "tit", 3, 40, 30, "inrfrnfj"));
            products.Add(new product(1, "tit", 3, 40, 30, "inrfrnfj"));
            products.Add(new product(1, "tit", 3, 40, 30, "inrfrnfj"));
            products.Add(new product(1, "tit", 3, 40, 30, "inrfrnfj"));
            genrateProductListView();
        }
        private void genrateProductListView()
        {
            panalContainer.Controls.Clear();
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
            //uc_.setImage(p.image);
            uc.setQuantity(p.quantity);
            uc.setSellPrice(p.sellPrice);
            uc.setFactoryPrice(p.factoryPrice);
            uc.setId(p.id);
            int uc_count = panalContainer.Controls.Count;
            if (uc_count != 0)
            {
                uc.Location = new Point(uc.Location.X
                    , uc.Location.Y + (uc_count * uc.Height));
            }
            panalContainer.Controls.Add(uc);
        }
        private void filter()
        {
            if (search.Text.Trim().Length > 0 && !search.Text.Equals("Search"))
            {
                panalContainer.Controls.Clear();
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

        private void addProducts_Click(object sender, EventArgs e)
        {
            panalContainer.Controls.Clear();
            addProductUC uc = new addProductUC();
            uc.BringToFront();
            uc.Dock = DockStyle.Fill;
            panalContainer.Controls.Add(uc);
        }

        private void Home_Click(object sender, EventArgs e)
        {

            genrateProductListView();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCashier_Click(object sender, EventArgs e)
        {
            panalContainer.Controls.Clear();
            registercashierUC uc = new registercashierUC();
            uc.BringToFront();
            uc.Dock = DockStyle.Fill;
            panalContainer.Controls.Add(uc);
        }
    }
}
