using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Inheritance
{
    public class AveragingAggregator : PointsAggregator
    {
        public AveragingAggregator(IEnumerable<Measurement> measurements)
            : base(measurements)
        {
        }

        protected override IEnumerable<Measurement> FilterMeasurements(IEnumerable<Measurement> measurements)
        {
            return measurements;
        }

        protected override Measurement AggregateMeasurements(IEnumerable<Measurement> measurements)
        {           
            return new Measurement
                       {
                           X = (int)measurements.Average(m => m.X), 
                           Y = (int)measurements.Average(m => m.Y)
                       };
        }
    }
}