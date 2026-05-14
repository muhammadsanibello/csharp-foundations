using System;

namespace School_Management_System
{
    public class School
    {
        public string Name { get; private set; }

        private Person[] _people;
        private int _maxPeople;
        private int _peopleCount;

        public School(string name, int maxPeople)
        {

            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name), "Cannot be empty");

            if (maxPeople <= 0) throw new ArgumentException(nameof(maxPeople), "Must be greater than 0");

            Name = name;
            _maxPeople = maxPeople;
            _people = new Person[_maxPeople];
            _peopleCount = 0;

        }

        public void AddPerson(Person person)
        {
            if (_peopleCount >= _maxPeople)
            {
                Console.WriteLine("School is full");
                return;
            }

            if (SearchPerson(person))
            {
                Console.WriteLine("Person already exist");
                return;
            }

            _people[_peopleCount] = person;
            _peopleCount++;
        }

        public void RemovePerson(Person person)
        {
            for (int i = 0; i < _peopleCount; i++)
            {
                if (_people[i].ID == person.ID)
                {
                    // Shift everything left by one
                    for (int j = i; j < _peopleCount - 1; j++)
                    {
                        _people[j] = _people[j + 1];
                    }

                    // clear the last slot
                    _people[_peopleCount - 1] = null;

                    // decrement the counter
                    _peopleCount--;

                    break;
                }
            }
        }

        public bool SearchPerson(Person person)
        {
            for (int i = 0; i < _peopleCount; i++)
            {
                if (_people[i].ID == person.ID)
                {
                    return true;
                }
            }

            return false;
        }

        public void DisplayAllPeople()
        {
            for (int i = 0; i < _peopleCount; i++)
            {
                _people[i].DisplayInfo();
            }
        }

    }
}
