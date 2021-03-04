using System;
namespace classes
{
    public static class AccountFactory
    {
        public static IAccount GetAccount(string accountType)
        {
            switch (accountType)
            {
                case "Checking":
                    return new Checking();
                case "Saving":
                    return new Saving();
                case "Business":
                    return new Business();
                default:
                    return new Checking();
            }
        }
        
    }
}
