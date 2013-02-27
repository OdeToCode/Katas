package algorithm.inhereitance;

import java.util.Collection;

import algorithm.Measurement;

public abstract class PointsAggregator {

	protected abstract Collection<Measurement> filterMeasurements();
	protected abstract Measurement aggregateMeasurements();

	protected Collection<Measurement> measurements;

	protected PointsAggregator(Collection<Measurement> measurements) {
		this.measurements = measurements;
	}

	public Measurement aggregate() {
		measurements = filterMeasurements();
		return aggregateMeasurements();
	}

}
