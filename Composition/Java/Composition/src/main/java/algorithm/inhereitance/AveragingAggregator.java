package algorithm.inhereitance;

import static algorithm.MeasurementUtil.averageX;
import static algorithm.MeasurementUtil.averageY;

import java.util.Collection;

import algorithm.Measurement;

public class AveragingAggregator extends PointsAggregator {

	public AveragingAggregator(Collection<Measurement> measurements) {
		super(measurements);
	}

	@Override
	protected Collection<Measurement> filterMeasurements(Collection<Measurement> measurements) {
		return measurements;
	}

	@Override
	protected Measurement aggregateMeasurements(Collection<Measurement> measurements) {
		return new Measurement(averageX(measurements), averageY(measurements));

	}
}
