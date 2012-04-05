using System;

namespace Algorithm.MarginallyBetter
{
    public class Finder
    {
        private readonly PersonList _people;

        public Finder(PersonList people)
        {
            _people = people;
        }

        public PersonDifference Find(Func<PersonDifference, PersonDifference, bool> findStrategy)
        {
            var differences = new PersonDifferenceList(_people);
            var answer = differences.Find(findStrategy);
            return answer;
        }               
    }
}