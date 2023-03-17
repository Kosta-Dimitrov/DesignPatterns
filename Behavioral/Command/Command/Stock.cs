using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Stock
    {
        private string name;
        private int price;

        public Stock(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public string GetName()
            => this.name;

        public int GetPrice()
            => this.price;

        public void buy()
        {
            Console.WriteLine($"Stock [ Name: { name }, Price: { price }] bought");
        }

        public void sell()
        {
            Console.WriteLine($"Stock [ Name: { name }, Price: { price }] sold");
        }

    }
}
