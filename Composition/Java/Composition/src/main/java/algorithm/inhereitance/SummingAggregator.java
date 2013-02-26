package algorithm.inhereitance;

import static algorithm.MeasurementUtil.sumX;
import static algorithm.MeasurementUtil.sumY;

import java.util.Collection;

import algorithm.Measurement;

public class SummingAggregator extends PointsAggregator {

	public SummingAggregator(Collection<Measurement> measurements) {
		super(measurements);
	}

	@Override
	protected Collection<Measurement> filterMeasurements(Collection<Measurement> measurements) {
		return measurements;
	}

	@Override
	protected Measurement aggregateMeasurements(Collection<Measurement> measurements) {
		return new Measurement(sumX(measurements), sumY(measurements));
	}
}
