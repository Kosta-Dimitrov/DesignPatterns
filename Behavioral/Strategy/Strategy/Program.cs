using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IPaymentStrategy  paypalStrategy= new PaypalStrategy("jeff.bezos@amazon.com", "mypwd", 100);
            IPaymentStrategy creditCardStrategy = new CreditCardStrategy("Jeff Bezos", 190);

            ShoppingCart cart = new ShoppingCart(paypalStrategy);

            Item item1 = new Item("banana", 10);
            Item item2 = new Item("milk", 40);

            cart.addItem(item1);
            cart.addItem(item2);

            cart.pay();


            cart.setStrategy(creditCardStrategy);
            cart.pay();
        }
    }
}
