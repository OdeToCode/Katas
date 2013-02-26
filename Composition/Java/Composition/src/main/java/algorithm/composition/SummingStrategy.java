package algorithm.composition;

import static algorithm.MeasurementUtil.sumX;
import static algorithm.MeasurementUtil.sumY;

import java.util.Collection;

import algorithm.Measurement;

public class SummingStrategy implements IAggregationStrategy {

	@Override
	public Measurement aggregate(Collection<Measurement> measurements) {
		return new Measurement(sumX(measurements), sumY(measurements));
	}
}
