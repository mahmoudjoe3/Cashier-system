using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cacharSystem.Model
{
    public class Bills
    {

        //  public virtual IdentityUser  { get; set; }
       
        public int Id { get; set; }
        public string products_ids { get; set; }       
        public float cost { get; set; }     
        public float Discount { get; set; }      
        public string Cashier { get; set; }  
        public float Taxes { get; set; }
        public string date { get; set; }
        public bool IsDeleted { get; set; }



    }
}
