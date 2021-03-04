using System;
namespace classes
{
    public class Checking : IAccount
    {
        public int Pin { set; get; }
        public string Amount { set; get; }
        public double Balance { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string StreetAddress { set; get; }
        public string Address2 { set; get; }
        public string City { set; get; }
        public string State { set; get; }
        public int Zip { set; get; }
        public string PhoneNumber { set; get; }
        public string AccountType { get; set; }

        public Checking()
        {
            AccountType = "Saving Account";
            Balance = 100;
        }
        public double CheckBalance()
        {
            return Balance;
        }

        public int CreateAccount(int pin)
        {
            return pin;
        }

        public double Deposit(double amount)
        {
            return Balance += amount;
        }

        public string PInfo(string fName, string lName, string stAddress, string address2, string city, string st, int zip, string phone)
        {
            return "#" + " " + fName + " " + lName + " " + stAddress + " " + address2 + " " + city + " " + st + " " + zip + " " + phone;
        }

        public bool PinValidator(int pin)
        {
            if (pin == Pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Withdraw(double amount)
        {
            return Balance -= amount;

        }
    }
}
