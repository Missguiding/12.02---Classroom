using System;


namespace Persons
{
    class Person
    {
        private string _strName; // fields
        private DateTime _dtmBirthdate;
        private string _strStreet;
        private string _strHouseNumber;
        private string _strZipCode;
        private string _strCity;

        public string Name { get; set; } // automatic property 

        public DateTime BirthDate { get; set; } // automatic property 

        public string Street { get; set; } // automatic property  

        public string HouseNumber { get; set; } // automatic property  

        public string ZipCode { get; set; } // automatic property  

        public string City { get; set; } //field and automatic property 
       
        public string Address       // dynamic property - get's street, number, zipcode and city, returns full adress
        {
            get
            {
                string _strAddress = Street + " " + HouseNumber + "\n" + ZipCode + " " + City;
                return _strAddress;
            }
            
        }        

        public virtual object ShowInformation() // method for showing the information of the class 
        {
            string _strPersonsInfo = BirthDate + "\n" + Name + "\n" + Address + "\n";

            return _strPersonsInfo;
        }

        public Person(string _strName, DateTime _dtmBirthDate, string _strStreet, string _strHouseNumber, string _strZipCode, string _strCity) // constructor with 6 properties
        {
            Name = _strName;
            BirthDate = _dtmBirthDate;
            Street = _strStreet;
            HouseNumber = _strHouseNumber;
            ZipCode = _strZipCode;
            City = _strCity;
        }
    }
}


