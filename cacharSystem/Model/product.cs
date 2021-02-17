using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cacharSystem.Model
{
    class product
    {
        
        public int id { get; set; }
        public String title { get; set; }
        public int quantity { get; set; }
        public float sellPrice { get; set; }
        public float factoryPrice { get; set; }
        public byte[] img { get; set; }
        

    }
}
