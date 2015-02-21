using System;

namespace Algorithm
{
    public class DateOfBirthProximityResult
    {
        public Person EldestPerson { get; set; }
        public Person YoungestPerson { get; set; }
        public TimeSpan D { get; set; }
    }
}