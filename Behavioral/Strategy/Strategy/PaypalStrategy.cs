using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class PaypalStrategy : IPaymentStrategy
    {
        private string email;
        private string password;
        private double money;

        public PaypalStrategy(string email, string password, double money)
        {
            this.email = email;
            this.password = password;
            this.money = money;
        }

        public double getMoney()
            => this.money;

        public void pay(double amount)
        {
            Console.WriteLine($"Paid { amount } using { email } paypal profile");
        }

    }
}
