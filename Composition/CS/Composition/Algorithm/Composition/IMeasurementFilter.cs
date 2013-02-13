using System.Collections.Generic;

namespace Algorithm.Composition
{
    public interface IMeasurementFilter
    {
        IEnumerable<Measurement> Filter(IEnumerable<Measurement> measurements);
    }
}