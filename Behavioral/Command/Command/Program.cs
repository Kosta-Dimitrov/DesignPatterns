using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock teslaStock = new Stock("Tesla", 123);
            Stock amazonStock = new Stock("Amzaon", 88);


            BuyStock buyAmazonStockOrder = new BuyStock(amazonStock);
            SellStock sellAmazonStockOrder = new SellStock(amazonStock);
            BuyStock buyTeslaStockOrder = new BuyStock(teslaStock);
            SellStock sellTeslaStockOrder = new SellStock(teslaStock);

            Broker broker = new Broker();
            broker.takeOrder(buyAmazonStockOrder);
            broker.takeOrder(sellAmazonStockOrder);
            broker.takeOrder(buyTeslaStockOrder);
            broker.takeOrder(sellTeslaStockOrder);


            broker.placeOrders();
        }
    }
}
