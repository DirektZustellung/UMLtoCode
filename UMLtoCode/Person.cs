using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace UMLtoCode
{
    public abstract class Person
    {
        public int ID;
        public string Name;
        protected string Phone;
        public string Email;
        public Address Address;
    }

    public class Employee : Person
    {
        public enum Department { }
        public Department department;
        private float Salary;
    }

    public class Customer : Person
    {
        public DateTime Registration;
        private int CreditScore;
        public Account account;
    }

    public class Account
    {
        public string IBAN;
        protected float Amount;
        public Transaction transaction;

        public bool Transaction(string temp)
        {
            return false;
        }
    }

    public struct Transaction
    {
        public string From;
        public string To;
        public float Amount;
        public DateTime Request;
    }

    public class Investing : Account
    {
        public float Interest;

        public void ApplyInterest()
        {

        }
    }

    public class Savings : Account
    {
        private float ProtectedAmount;

        public void LiberateSavings()
        {

        }
    }
}
