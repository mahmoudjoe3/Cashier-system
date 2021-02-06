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
    public partial class orderUC : UserControl
    {
        int orderId =0;
        public orderUC()
        {
            InitializeComponent();
        }
        public void setId(int id)
        {
            orderId = id;
        }
        public void setDate(String date)
        {
            order_date.Text = date;
        }
        public void setTime(String time)
        {
            order_time.Text = time;
        }
        public void setCashierName(String CashierName)
        {
            order_cashierName.Text = CashierName;
        }
        public void setTaxes(float taxes)
        {
            order_taxes.Text = taxes+"%";
        }
        public void setDiscount(float discount)
        {
            order_discount.Text = discount + "%";
        }
        public void setTotal(float total)
        {
            order_total.Text = total + " EGP";
        }
    }
}
