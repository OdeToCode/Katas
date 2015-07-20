using System;

namespace Algorithm
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public int CompareTo(Person other)
        {
            return BirthDate.CompareTo(other.BirthDate);
        }
    }
}