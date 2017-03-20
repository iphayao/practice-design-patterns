using System;
using System.Runtime.CompilerServices;

namespace ChainOfResponsibility
{
    abstract class Account
    {
        protected Account successor;
        protected double balance;
        public void SetNext(Account account)
        {
            this.successor = account;
        }
        public void pay(double amountToPay, [CallerMemberName]string memberName = "")
        {
            if(CanPay(amountToPay))
            {
                Console.WriteLine("Paid {0} using {1} ", amountToPay, memberName);
            }
            else if(successor != null)
            {
                Console.WriteLine("Cannot pay using {0}. Preceeding ..", memberName);
                successor.pay(amountToPay);
            }
            else
            {
                throw new Exception("None of an account have enought balance");
            }
        }
        public bool CanPay(double amount)
        {
            return this.balance >= amount;
        }
    }

    class Bank : Account
    {
        //protected double balance;

        public Bank(double balance)
        {
            this.balance = balance;
        }
    }

    class Paypal : Account
    {
        //protected double balance;

        public Paypal(double balance)
        {
            this.balance = balance;
        }
    }

    class Bitcoin : Account
    {
        //private double balance;
        
        public Bitcoin(double balance)
        {
            this.balance = balance;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank(100);
            Paypal paypal = new Paypal(200);
            Bitcoin bitcoin = new Bitcoin(300);

            bank.SetNext(paypal);
            paypal.SetNext(bitcoin);

            bank.pay(259);
        }
    }
}
