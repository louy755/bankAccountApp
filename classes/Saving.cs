using System;
namespace classes
{
    public class Saving : IAccount
    {
        public int Pin { get; set; }
        public string Amount { get; set; }
        public double Balance { get; set; }// account
        public string FirstName { get; set; }//personal info
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string AccountType { get; set; }

        public Saving()
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
        // only personal info
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
