using System.Collections.Generic;

namespace Algorithm
{
    public class DateOfBirthProximityService
    {
        private readonly List<Person> _p;

        public DateOfBirthProximityService(List<Person> p)
        {
            _p = p;
        }

        public DateOfBirthProximityResult Find(DateOfBirthProximity dateOfBirthProximity)
        {
            var tr = new List<DateOfBirthProximityResult>();

            for(var i = 0; i < _p.Count - 1; i++)
            {
                for(var j = i + 1; j < _p.Count; j++)
                {
                    var r = new DateOfBirthProximityResult();
                    if(_p[i].BirthDate < _p[j].BirthDate)
                    {
                        r.EldestPerson = _p[i];
                        r.YoungestPerson = _p[j];
                    }
                    else
                    {
                        r.EldestPerson = _p[j];
                        r.YoungestPerson = _p[i];
                    }
                    r.D = r.YoungestPerson.BirthDate - r.EldestPerson.BirthDate;
                    tr.Add(r);
                }
            }

            if(tr.Count < 1)
            {
                return new DateOfBirthProximityResult();
            }

            DateOfBirthProximityResult answer = tr[0];
            foreach(var result in tr)
            {
                switch(dateOfBirthProximity)
                {
                    case DateOfBirthProximity.Closest:
                        if(result.D < answer.D)
                        {
                            answer = result;
                        }
                        break;

                    case DateOfBirthProximity.Furthest:
                        if(result.D > answer.D)
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