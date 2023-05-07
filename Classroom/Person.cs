using System;

namespace Classroom
{
    class Person
    {
        public DateTime _dtmDateOfBirth; //fields
        private int _intAgeInYears = 0;
        private int _intAgeInDays = 0;

        public string FirstName { get; set; } // automatic property
        public string LastName { get; set; } // automatic property
        public DateTime BirthDate // property , get Birthday, not in the future.
        {
            get
            {
                if (_dtmDateOfBirth > DateTime.Today)
                {
                    Console.WriteLine("\n{0}, Your date of birth cannot be in the future, we will use current date!", FirstName);
                    return _dtmDateOfBirth = DateTime.Today;
                }
                else
                {
                    return _dtmDateOfBirth;
                }

            }
            set
            {
                _dtmDateOfBirth = value;
            }

        }

        public Person(string strFirstName, string strLastName, DateTime dtmBirthDate) // constructor with 3 parameters
        {
            FirstName = strFirstName;
            LastName = strLastName;
            BirthDate = dtmBirthDate;
        }

        public int AgeInYears // property
        {
            get
            {
                if ((DateTime.Now.Month < BirthDate.Month) || (BirthDate.Month == DateTime.Now.Month && DateTime.Now.Day < BirthDate.Day))
                {
                    Console.WriteLine("\n" + "{0}, YEARS on earth:", FirstName);
                    _intAgeInYears = DateTime.Now.Year - BirthDate.Year - 1;
                }

                else
                {
                    Console.WriteLine("\n" + "{0}, YEARS on earth:", FirstName);
                    _intAgeInYears = DateTime.Now.Year - BirthDate.Year;
                }

                return _intAgeInYears;
            }
            set
            {
                _intAgeInYears = value;
            }
        }

        public int AgeInDays // dynamic property
        {
            get
            {
                Console.WriteLine("\n" + "{0}, DAYS on earth:", FirstName);
                _intAgeInDays = Convert.ToInt32((DateTime.Now - BirthDate).TotalDays);

                return _intAgeInDays;
            }
            set
            {
                _intAgeInDays = value;
            }
        }
    }
}
