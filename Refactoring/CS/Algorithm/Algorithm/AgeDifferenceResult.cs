using System;

namespace Algorithm
{
    public class AgeDifferenceResult
    {
        public Person EldestPerson { get; set; }
        public Person YoungestPerson { get; set; }
        public TimeSpan DifferenceInAge { get; set; }
    }
}