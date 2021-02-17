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
    public partial class registercashierUC : UserControl
    {
        Dbcontext db;
        public registercashierUC()
        {
            InitializeComponent();
            db = new Dbcontext();
        }

        private void registercashierUC_Load(object sender, EventArgs e)
        {

        }

        private void addCashier_Click(object sender, EventArgs e)
        {

            User user = new User();
            user.Code =Convert.ToInt32(Code.Text);
            user.Name = name.Text;
            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Cashier Added Successfully");
        }
    }
}
