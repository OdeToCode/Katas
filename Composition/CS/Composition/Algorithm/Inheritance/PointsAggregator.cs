using System.Collections.Generic;

namespace Algorithm.Inheritance
{
    public abstract class PointsAggregator
    {
        protected PointsAggregator(IEnumerable<Measurement> measurements)
        {
            Measurements = measurements;
        }

        public virtual Measurement Aggregate()
        {
            var measurements = Measurements;
            measurements = FilterMeasurements(measurements);
            return AggregateMeasurements(measurements);
        }

        protected abstract IEnumerable<Measurement> FilterMeasurements(IEnumerable<Measurement> measurements);
        protected abstract Measurement AggregateMeasurements(IEnumerable<Measurement> measurements);
        
        protected readonly IEnumerable<Measurement> Measurements;
    }        
}