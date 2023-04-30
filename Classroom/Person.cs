using System;

namespace Classroom
{
    class Person
    {
        private DateTime _dtmDateOfBirth; //field
        private int _intAgeInYears = 0;
        private double _dblAgeInDays = 0D;

        private string FirstName { get; set; } // automatic property, private, class access only
        private string LastName { get; set; } // automatic property, private, class access only
        public DateTime BirthDate { get; set; } // automatic property

        public Person(string strFirstName, string strLastName, DateTime dtmBirthDate) // constructor with 3 parameters
        {
            FirstName = strFirstName;
            LastName = strLastName;
            BirthDate = dtmBirthDate;
        }

        public string FullName // dynamic property - give back full name
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public int AgeInYears // dynamic property
        {
            get
            {
                if ((DateTime.Now.Month < _dtmDateOfBirth.Month) || (_dtmDateOfBirth.Month == DateTime.Now.Month && DateTime.Now.Day < _dtmDateOfBirth.Day))
                {
                    _intAgeInYears = DateTime.Now.Year - BirthDate.Year - 1;
                }
                else
                {
                    _intAgeInYears = DateTime.Now.Year - BirthDate.Year;
                }

                return _intAgeInYears;
            }
        }

        public double AgeInDays // dynamic property
        {
            get
            {
                _dblAgeInDays = (DateTime.Now - BirthDate).TotalDays;

                return _dblAgeInDays;
            }
        }
    }
}
