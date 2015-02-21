using System.Collections.Generic;

namespace Algorithm
{
    public class AgeDifferenceService
    {
        private readonly List<Person> _people;

        public AgeDifferenceService(List<Person> people)
        {
            _people = people;
        }

        public AgeDifferenceResult Find(AgeDifference ageDifference)
        {
            var possibleResults = new List<AgeDifferenceResult>();

            for(var i = 0; i < _people.Count - 1; i++)
            {
                for(var j = i + 1; j < _people.Count; j++)
                {
                    var possibleResult = new AgeDifferenceResult();
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
                return new AgeDifferenceResult();
            }

            AgeDifferenceResult answer = possibleResults[0];
            foreach(var result in possibleResults)
            {
                switch(ageDifference)
                {
                    case AgeDifference.Closest:
                        if(result.DifferenceInAge < answer.DifferenceInAge)
                        {
                            answer = result;
                        }
                        break;

                    case AgeDifference.Furthest:
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