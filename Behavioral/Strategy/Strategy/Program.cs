using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            Item item1 = new Item("banana", 10);
            Item item2 = new Item("milk", 40);

            cart.addItem(item1);
            cart.addItem(item2);

            cart.pay(new PaypalStrategy("jeff.bezos@amazon.com", "mypwd", 100));

            cart.pay(new CreditCardStrategy("Jeff Bezos", 190));
        }
    }
}
