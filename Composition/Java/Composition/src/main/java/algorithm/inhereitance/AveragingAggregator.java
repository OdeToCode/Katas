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
	protected Collection<Measurement> filterMeasurements() {
		return measurements;
	}

	@Override
	protected Measurement aggregateMeasurements() {
		return new Measurement(averageX(measurements), averageY(measurements));

	}
}
