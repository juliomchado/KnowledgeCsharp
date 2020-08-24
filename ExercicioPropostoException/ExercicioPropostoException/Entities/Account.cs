using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using ExercicioPropostoException.Entities.Exception;

namespace ExercicioPropostoException.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new LimitException("The amount exceeds withdraw limit");
            }
            if(Balance < WithdrawLimit)
            {
                throw new LimitException("Not enough balance");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return $"New balance: {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
