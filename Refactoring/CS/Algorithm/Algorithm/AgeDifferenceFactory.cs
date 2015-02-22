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
                    if(_people[i].BirthDate < _people[j].BirthDate)
                    {
                        possibleResult.EldestPerson = _people[i];
                        possibleResult.YoungestPerson = _people[j];
                    }
                    else
                    {
                        possibleResult.EldestPerson = _people[j];
                        possibleResult.YoungestPerson = _people[i];
                    }
                    possibleResult.DifferenceInAge = possibleResult.YoungestPerson.BirthDate - possibleResult.EldestPerson.BirthDate;
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