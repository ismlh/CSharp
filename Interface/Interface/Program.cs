using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashier cashier = new Cashier(new cash());
            cashier.Checkout(100m);
            Cashier cashier1 = new Cashier(new Visa());
            cashier1.Checkout(100m);
            Cashier cashie2r = new Cashier(new masterCard());
            cashie2r.Checkout(100m);
        }
    }
     class Cashier
    {
        private IPayment _payment;
        public Cashier(IPayment payment)
        {
            this._payment = payment;
        }
        public void Checkout(decimal amount)
        {
            _payment.pay(amount);
        }
    }
    interface IPayment
    {
        void pay(decimal amount);
    }
    class cash : IPayment
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"You will pay {amount} using {GetType().ToString().Replace("Interface.","")}");
        }
    }
    class Visa : IPayment
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"You will pay {amount} using {GetType().ToString().Replace("Interface.", "")}");
        }
    }
    class masterCard : IPayment
    {
        public void pay(decimal amount)
        {
            Console.WriteLine($"You will pay {amount} using {GetType().ToString().Replace("Interface.", "")}");
        }
    }
}
