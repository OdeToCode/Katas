using System;

namespace Algorithm
{
    public class AgeDifference
    {
        public Person EldestPerson { get; set; }
        public Person YoungestPerson { get; set; }
        public TimeSpan DifferenceInAge { get; set; }

        public void SetPeople(Person firstPerson, Person secondPerson)
        {
            if(firstPerson.IsOlderThan(secondPerson))
            {
                EldestPerson = firstPerson;
                YoungestPerson = secondPerson;
            }
            else
            {
                EldestPerson = secondPerson;
                YoungestPerson = firstPerson;
            }
            DifferenceInAge = YoungestPerson.BirthDate - EldestPerson.BirthDate;
        }
    }
}