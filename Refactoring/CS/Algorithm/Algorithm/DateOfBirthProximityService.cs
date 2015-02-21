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
                        r.P1 = _p[i];
                        r.P2 = _p[j];
                    }
                    else
                    {
                        r.P1 = _p[j];
                        r.P2 = _p[i];
                    }
                    r.D = r.P2.BirthDate - r.P1.BirthDate;
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