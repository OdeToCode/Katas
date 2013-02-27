package algorithm.composition;

import java.util.Collection;

import algorithm.Measurement;
import algorithm.MeasurementUtil;

public class AveragingStrategy implements IAggregationStrategy {

	@Override
	public Measurement aggregate(Collection<Measurement> measurements) {
		return new Measurement(MeasurementUtil.averageX(measurements), MeasurementUtil.averageY(measurements));
	}

}
