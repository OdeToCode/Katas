using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Inheritance
{
    public class SummingAggregator : PointsAggregator
    {
        public SummingAggregator(IEnumerable<Measurement> measurements) : base(measurements)
        {
        }

        protected override IEnumerable<Measurement> FilterMeasurements(IEnumerable<Measurement> measurements)
        {
            return measurements;
        }

        protected override Measurement AggregateMeasurements(IEnumerable<Measurement> measurements)
        {
            return new Measurement {X = measurements.Sum(m => m.X), Y = measurements.Sum(m => m.Y)};
        }
    }
}