using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avoda_Managerment.Models
{
    public class Product
    {
        private int id;
        private string type;
        private string name;
        private string color;
        private string size;
        private int stock;
        private long price;

        public Product()
        { }

        public Product(int id, string type, string name, string color, string size, int stock, long price)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.color = color;
            this.size = size;
            this.stock = stock;
            this.price = price;
        }

        public int Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public string Color { get => color; set => color = value; }
        public string Size { get => size; set => size = value; }
        public int Stock { get => stock; set => stock = value; }
        public long Price { get => price; set => price = value; }
    }
}