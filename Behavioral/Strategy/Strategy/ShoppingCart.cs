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
        private IPaymentStrategy paymentStrategy;

        public ShoppingCart(IPaymentStrategy paymentStrategy)
        {
            this.items = new List<Item>();
            setStrategy(paymentStrategy);
        }

        public void addItem(Item item)
        {
            this.items.Add(item);
        }

        public void setStrategy(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void pay()
        {
            double amount = this.calculateTotal();
            this.paymentStrategy.pay(amount);
        }

        private double calculateTotal()
            => this.items
                .Sum(i => i.GetPrice());
    }
}
