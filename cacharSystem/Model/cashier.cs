using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cacharSystem.Model
{
    class cashier
    {
        public string Cashier_name { get; set; }
        public string Cashier_Email { get; set; }
        public string Cashier_id { get; set; }
        public string Cashier_password { get; set; }

        public cashier(string cashier_name, string cashier_Email, string cashier_id, string cashier_password)
        {
            Cashier_name = cashier_name;
            Cashier_Email = cashier_Email;
            Cashier_id = cashier_id;
            Cashier_password = cashier_password;
        }

        public cashier(string cashier_name, string cashier_id, string cashier_password)
        {
            Cashier_name = cashier_name;
            Cashier_id = cashier_id;
            Cashier_password = cashier_password;
        }
    }
}
