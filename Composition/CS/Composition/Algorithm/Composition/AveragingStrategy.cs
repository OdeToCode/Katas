using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Composition
{
    public class AveragingStrategy : IAggregationStrategy
    {
        public Measurement Aggregate(IEnumerable<Measurement> measurements)
        {
            return new Measurement
                       {
                           X = (int)measurements.Average(m => m.X),
                           Y = (int)measurements.Average(m => m.Y)
                       };
        }
    }
}