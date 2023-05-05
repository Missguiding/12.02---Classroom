using System;


    namespace Persons
    {
        class Person
        {
            private string _strAdress; // field


            public string Name { get; set; } // field and automatic property 

            public DateTime BirthDate { get; set; } // field and automatic property 

            public string Street { get; set; } // field and automatic property 

            public string HouseNumber { get; set; } // field and automatic property 

            public string ZipCode { get; set; } // field and automatic property 

            public string City { get; set; } //field and automatic property 

            private string Adress // dynamic property - get's street, number, zipcode and city, returns full adress
            {
                get
                {
                    _strAdress = Street + " " + HouseNumber + "\n" + ZipCode + " " + City;
                    return _strAdress;
                }
                set
                {
                    value = _strAdress;
                }
            }

            public virtual string AllInformation // property using method
            {
                get
                {
                    return ShowInformation();
                }

                set
                {
                    value = ShowInformation();
                }

            }

            private string ShowInformation() // method for showing the information of the class 
            {
                string _strPersonsInfo = BirthDate + "\n" + Name + "\n" + Adress + "\n";

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


