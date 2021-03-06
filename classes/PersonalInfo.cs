﻿using System;
using System.Text.RegularExpressions;

namespace classes
{
    public class PersonalInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string PInfo(string fName,string lName, string stAddress, string address2, string city, string st,int zip, string phone )
        {
            return "#" + " " + fName + " " + lName + " " + stAddress + " " +address2 + " " +city + " " +st + " " +zip + " " +phone;
        }
        
    }
}
