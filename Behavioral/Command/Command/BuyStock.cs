namespace Command
{
    public class BuyStock : IOrder
    {
        private Stock stock;

        public BuyStock(Stock stock)
        {
            this.stock = stock;
        }

        public void execute()
        {
            this.stock.buy();
        }
    }
}
