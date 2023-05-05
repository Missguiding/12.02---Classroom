﻿using System;

namespace Persons
{
    class Student : Person
    {

        public string School { get; set; } // field and automatic property 

        public override string AllInformation // dynamic property base person plus information student
        {
            get => base.AllInformation + School + "\n";
        }
        public Student(string _strName, DateTime _dtmBirthDate, string _strStreet, string _strHouseNumber, string _strZipCode, string _strCity, string _strSchool) : base(_strName, _dtmBirthDate, _strStreet, _strHouseNumber, _strZipCode, _strCity)
        // constructor inheriting from parent person with 1 extra parameters
        {
            School = _strSchool;
        }

    }
}





