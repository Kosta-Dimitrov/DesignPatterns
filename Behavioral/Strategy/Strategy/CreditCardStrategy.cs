using System;

namespace Strategy
{
    public class CreditCardStrategy : IPaymentStrategy
    {
        private double money;
        private string name;

        public CreditCardStrategy(string name, double money)
        {
            this.name = name;
            this.money = money;
        }

        public double GetMoney()
            => this.money;

        public void pay(double amount)
        {
            this.money -= amount;
            Console.WriteLine($"Paid { amount } with { name } credit card");
        }
    }
}
