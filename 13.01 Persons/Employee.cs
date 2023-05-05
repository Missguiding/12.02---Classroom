using System;

namespace Persons
{

    namespace Persons
    {
        class Employee : Person
        {
            public Employee(string _strName, DateTime _dtmBirthDate, string _strStreet, string _strHouseNumber, string _strZipCode, string _strCity, string _strCompagny, double _dblWage) : base(_strName, _dtmBirthDate, _strStreet, _strHouseNumber, _strZipCode, _strCity)
            // constructor inheriting from parent person with 2 extra parameters
            {
                Compagny = _strCompagny;
                Wage = _dblWage;
            }

            public string Compagny { get; set; } // field and automatic property 

            public double Wage { get; set; } // field and automatic property 

            public override string AllInformation // dynamic property base person plus information employee
            {
                get => base.AllInformation + Compagny + "\n" + Wage + "\n";
            }
        }
    }

}
