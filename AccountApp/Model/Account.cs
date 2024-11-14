﻿using AccountApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Model
{
    internal class Account
    {
        public int Id { get; set; }
        public string? Iban { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public string? Ssn { get; set; }
        public decimal Balance { get; set; }

        public Account()
        {
            
        }

        public Account(int id, string? iban, string? firstname, string? lastname, 
            string? ssn, decimal balance)
        {
            Id = id;
            Iban = iban;
            Firstname = firstname;
            Lastname = lastname;
            Ssn = ssn;
            Balance = balance;
        }

        public override string ToString()
        {
            return $"{{ {Id}\t{Firstname}\t{Lastname}\t{Ssn}\t{Balance} }}";
        }

        /// <summary>
        /// Deposits an amount of money to the <see cref="Account" />
        /// </summary>
        /// <param name="amount">The amount of money</param>
        public void Deposit(decimal amount)
        {
            try
            {
                if (amount < 0) throw new NegativeAmountException("Error. Amount must not be negative.");
                Balance += amount;
            } catch ( NegativeAmountException ex )
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="ssn"></param>
        public  void Withdraw(decimal amount, string ssn)
        {
            try
            {
                if (string.IsNullOrEmpty(ssn)) throw new InvalidSsnException(ssn);
                if (Ssn != ssn) throw new InvalidSsnException(ssn);
                if (amount < 0) throw new NegativeAmountException("Error. Amount must not be negative");
                if (amount > Balance) throw new InsufficientBalanceException("Error. Insufficient balance.");

                Balance -= amount;
            }
            catch (NegativeAmountException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            } catch (InvalidSsnException ex)
            { 
                Console.WriteLine(ex.Message); 
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public decimal GetBalance(decimal amount)
        {
            return Balance;
        }
    }
}
