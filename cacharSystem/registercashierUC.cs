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
        public registercashierUC()
        {
            InitializeComponent();
        }

        private void registercashierUC_Load(object sender, EventArgs e)
        {

        }

        private void addCashier_Click(object sender, EventArgs e)
        {
            
            string Cashier_name = name.Text.ToString();
            string Cashier_Email = email.Text.ToString();
            string Cashier_id = nationalId.Text.ToString();
            string Cashier_password = password.Text.ToString();
            string confirmpass = confirmPassword.Text.ToString();
            if (!(String.IsNullOrEmpty(Cashier_name)||
                String.IsNullOrEmpty(Cashier_password) ||
                String.IsNullOrEmpty(confirmpass) ||
                String.IsNullOrEmpty(Cashier_id))&&
                Cashier_password.Equals(confirmpass))
            {
                cashier cashier;
                if (String.IsNullOrEmpty(Cashier_Email))
                    cashier = new cashier(Cashier_name, Cashier_id, Cashier_password);
                else if (Cashier_Email.Contains("@") && Cashier_Email.Contains("."))
                    cashier = new cashier(Cashier_name, Cashier_Email, Cashier_id, Cashier_password);
                MessageBox.Show("Cashier :: "+Cashier_name+"  iserted successfuly");
            }
            else
            {
                MessageBox.Show("there is incompleted data");
            }
        }
    }
}
