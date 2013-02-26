using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Composition
{
    public class SummingStrategy : IAggregationStrategy
    {
        public Measurement Aggregate(IEnumerable<Measurement> measurements)
        {
            return new Measurement { X = measurements.Sum(m => m.X), Y = measurements.Sum(m => m.Y) };
        }
    }
}