package algorithm.composition;

import java.util.Collection;

import algorithm.Measurement;
import algorithm.MeasurementUtil;

public class LowPassFilter implements IMeasurementFilter {

	@Override
	public Collection<Measurement> filter(Collection<Measurement> measurements) {
		return MeasurementUtil.WhereLessThanXandY(measurements, 100, 100);
	}

}
