package algorithm.composition;

import java.util.Collection;

import algorithm.Measurement;

public class EmptyFilter implements IMeasurementFilter {

	@Override
	public Collection<Measurement> filter(Collection<Measurement> measurements) {
		return measurements;
	}

}
