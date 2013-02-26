using System.Collections.Generic;

namespace Algorithm.Composition
{
    public interface IAggregationStrategy
    {
        Measurement Aggregate(IEnumerable<Measurement> measurements);
    }
}