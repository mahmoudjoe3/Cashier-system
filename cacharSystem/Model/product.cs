using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cacharSystem.Model
{
    class product
    {
        public product(int id,String title,
            int quantity, float sellPrice, float factoryPrice, String image)
        {
            this.id = id;
            this.title = title;
            this.quantity = quantity;
            this.sellPrice = sellPrice;
            this.factoryPrice = factoryPrice;
            this.image = image;
        }
        public product( String title,
            int quantity, float sellPrice, float factoryPrice, String image)
        {
            this.title = title;
            this.quantity = quantity;
            this.sellPrice = sellPrice;
            this.factoryPrice = factoryPrice;
            this.image = image;
        }
        public int id { get; set; }
        public String title { get; set; }
        public int quantity { get; set; }
        public float sellPrice { get; set; }
        public float factoryPrice { get; set; }
        public String image { get; set; }

    }
}
