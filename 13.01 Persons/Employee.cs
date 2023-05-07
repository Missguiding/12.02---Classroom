using System;

namespace Persons
{

    namespace Persons
    {
        class Employee : Person
        {
            public Employee(string _strName, DateTime _dtmBirthDate, string _strStreet, string _strHouseNumber, string _strZipCode, string _strCity, string _strCompany, double _dblWage) : base(_strName, _dtmBirthDate, _strStreet, _strHouseNumber, _strZipCode, _strCity)
            // constructor inheriting from parent person with 2 extra parameters
            {
                Company = _strCompany;
                Wage = _dblWage;
            }

            public string Company { get; set; } // field and automatic property 

            public double Wage { get; set; } // field and automatic property 

            public override object ShowInformation() // method use base + class info
            {
                {
                    return base.ShowInformation() + Company + "\n" + Wage + "\n";
                }
            }
        }
    }
}
