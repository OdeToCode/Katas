using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class AgeDifferenceFactory
    {
        private readonly List<Person> _people;

        public AgeDifferenceFactory(List<Person> people)
        {
            _people = people;
        }

        public AgeDifference Find(AgeDifferenceType ageDifferenceType)
        {
            var possibleResults = new List<AgeDifference>();

            for(var i = 0; i < _people.Count - 1; i++)
            {
                for(var j = i + 1; j < _people.Count; j++)
                {
                    var possibleResult = new AgeDifference();
                    var firstPerson = _people[i];
                    var secondPerson = _people[j];
                    possibleResult.SetPeople(firstPerson, secondPerson);
                    possibleResults.Add(possibleResult);
                }
            }

            if(possibleResults.Count < 1)
            {
                return new AgeDifference();
            }

            possibleResults.Sort();
            switch (ageDifferenceType)
            {
                case AgeDifferenceType.Closest:
                    return possibleResults.First();

                case AgeDifferenceType.Furthest:
                    return possibleResults.Last();
            }
            return new AgeDifference();
        }
    }
}