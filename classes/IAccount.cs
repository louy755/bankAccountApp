using System;
namespace classes
{
    public interface IAccount : IPersonalInfo
    {
        public int Pin { get; set; }
        public string Amount { get; set; }
        public double Balance { get; set; }
        public string AccountType { get; set; }

        public bool PinValidator(int pin);
        public int CreateAccount(int pin);
        public double CheckBalance();
        public double Withdraw(double amount);
        public double Deposit(double amount);
    }


}
