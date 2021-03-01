using System;
using Xunit;

namespace classesTest
{
    public class AccountTest
    {
        [Theory]
        [InlineData(123456, 123456)]
        public void CreatAccount(int pin,int expectedVal1)
        { 
            classes.Account accountInstance = new classes.Account();
            double acutalVal1 = accountInstance.CreateAccount(pin);
            Assert.Equal(acutalVal1, expectedVal1);
        }

        [Theory]
        [InlineData(100)]
        public void CheckBalance(double expectedVal)
        {
            classes.Account accountInstance = new classes.Account();
            double acutalVal = accountInstance.CheckBalance();
            Assert.Equal(acutalVal, expectedVal);
        }
        [Theory]
        [InlineData(100, 0)]
        public void Withdraw(double amount, double expectedVal)
        {
            classes.Account accountInstance = new classes.Account();
            double acutalVal = accountInstance.Withdraw(amount);
            Assert.Equal(acutalVal, expectedVal);
        }
        [Theory]
        [InlineData(100, 200)]
        public void Deposit(double amount, double expectedVal)
        {
            classes.Account accountInstance = new classes.Account();
            double acutalVal = accountInstance.Deposit(amount);
            Assert.Equal(acutalVal, expectedVal);
        }

    }
}
