using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Item
    {
        private string name;
        private double price;

        public Item(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public double GetPrice()
            => this.price;

        public string GetName()
            => this.name;
    }
}
