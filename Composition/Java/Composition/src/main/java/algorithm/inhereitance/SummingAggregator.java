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
	protected Collection<Measurement> filterMeasurements() {
		return measurements;
	}

	@Override
	protected Measurement aggregateMeasurements() {
		return new Measurement(sumX(measurements), sumY(measurements));
	}
}
