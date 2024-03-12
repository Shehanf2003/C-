using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SimpleBankAccount
{
    class BankAccount
    {
        private int AccountNumber;

        private double Balance;
        public double balance
        {
            get { return Balance; }
            set { Balance = value; }    
        }


        public BankAccount( double initialBalance)
        {

            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Console.WriteLine("Your Deposit Amount $" + amount);
            balance+= amount;
            Console.WriteLine($"Deposit Successful! New Balance: ${balance}");
            Console.ReadLine();
        }
    }
}
