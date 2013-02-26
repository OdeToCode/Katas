using System.Collections.Generic;

namespace Algorithm.Composition
{
    public class EmptyFilter : IMeasurementFilter
    {
        public IEnumerable<Measurement> Filter(IEnumerable<Measurement> measurements)
        {
            return measurements;
        }
    }
}