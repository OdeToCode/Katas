using System;

namespace Algorithm
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public bool IsOlderThan(Person secondPerson)
        {
            return BirthDate.CompareTo(secondPerson.BirthDate) < 0;
        }
    }
}