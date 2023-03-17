using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ShoppingCart
    {
        private List<Item> items;

        public ShoppingCart()
        {
            this.items = new List<Item>();
        }

        public void addItem(Item item)
        {
            this.items.Add(item);
        }


        public void pay(IPaymentStrategy paymentMethod)
        {
            double amount = this.calculateTotal();
            paymentMethod.pay(amount);
        }

        private double calculateTotal()
            => this.items
                .Sum(i => i.GetPrice());
    }
}
