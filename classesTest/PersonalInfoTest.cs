using System;
using Xunit;

namespace classesTest
{
    public class PersonalInfoTest
    {
        [Theory]
        [InlineData("Louy", "Alsadi", "1234 Chicago ST", "G5", "Chicago", "IL", 60123, "1234567890" , "# Louy Alsadi 1234 Chicago ST G5 Chicago IL 60123 1234567890")]
        public void PInfo(string fName, string lName, string stAddress, string address2, string city, string st, int zip, string phone, string expectedVal1)
        {
            classes.PersonalInfo oPersonalInfo = new classes.PersonalInfo();
            string acutalVal1 = oPersonalInfo.PInfo(fName, lName, stAddress, address2, city, st, zip, phone);
            Assert.Equal(acutalVal1, expectedVal1);
        }
   
    }
}
