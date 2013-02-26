package algorithm.inhereitance;

import java.util.Collection;

import algorithm.Measurement;
import algorithm.MeasurementUtil;

public class LowPassAveragingAggregator extends AveragingAggregator {

	public LowPassAveragingAggregator(Collection<Measurement> measurements) {
		super(measurements);
	}

	@Override
	protected Collection<Measurement> filterMeasurements(Collection<Measurement> measurements) {
		return MeasurementUtil.WhereLessThanXandY(measurements, 100, 100);
	}
}
