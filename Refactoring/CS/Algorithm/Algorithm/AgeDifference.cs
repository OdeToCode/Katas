using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class AgeDifference : IComparable<AgeDifference>
    {
        public Person EldestPerson { get; set; }
        public Person YoungestPerson { get; set; }
        public TimeSpan DifferenceInAge { get; set; }

        public void SetPeople(Person firstPerson, Person secondPerson)
        {
            var people = new List<Person> {firstPerson, secondPerson};
            people.Sort();
            YoungestPerson = people.Last();
            EldestPerson = people.First();
            DifferenceInAge = YoungestPerson.BirthDate - EldestPerson.BirthDate;
        }

        public int CompareTo(AgeDifference other)
        {
            return DifferenceInAge.CompareTo(other.DifferenceInAge);
        }
    }
}