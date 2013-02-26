package algorithm.inhereitance;

import java.util.Collection;

import algorithm.Measurement;

public abstract class PointsAggregator {

	protected abstract Collection<Measurement> filterMeasurements(Collection<Measurement> measurements);
	protected abstract Measurement aggregateMeasurements(Collection<Measurement> measurements);

	protected Collection<Measurement> measurements;

	protected PointsAggregator(Collection<Measurement> measurements) {
		this.measurements = measurements;
	}

	public Measurement aggregate() {
		measurements = filterMeasurements(measurements);
		return aggregateMeasurements(measurements);
	}

}
