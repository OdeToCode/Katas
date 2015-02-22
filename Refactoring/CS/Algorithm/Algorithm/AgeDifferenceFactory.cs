using System.Collections.Generic;

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

            AgeDifference answer = possibleResults[0];
            foreach(var result in possibleResults)
            {
                switch(ageDifferenceType)
                {
                    case AgeDifferenceType.Closest:
                        if(result.DifferenceInAge < answer.DifferenceInAge)
                        {
                            answer = result;
                        }
                        break;

                    case AgeDifferenceType.Furthest:
                        if(result.DifferenceInAge > answer.DifferenceInAge)
                        {
                            answer = result;
                        }
                        break;
                }
            }

            return answer;
        }
    }
}