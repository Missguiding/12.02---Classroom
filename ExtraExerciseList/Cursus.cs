using System.Collections.Generic;

namespace ExtraExerciseList
{
    public class Cursus
    {
        public string Description { get; set; } // property
        public List<Person> persons; // list

        public Cursus(string strDescription) // constructor 
        {
            Description = strDescription;
            persons = new List<Person>();
        }

        public void Add(Person strAperson) // method add person 
        {
            persons.Add(strAperson);
        }

        public Person this[int index] // indexer on index
        {
            get
            {
                return persons[index];
            }

            set
            {
                persons[index] = value;
            }
        }

        public Person this[string strAPerson] // indexer on name person 
            // kun je daar een set in zetten? heb hem weggelaten omdat het nu een string is
        {
            get
            {
                foreach (Person person in persons)
                {
                    if (person.FirstName == strAPerson)
                    {
                        return person;
                    }
                }
                return null;
            }
        }
    }
}

