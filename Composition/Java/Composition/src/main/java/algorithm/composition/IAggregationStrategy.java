package algorithm.composition;

import java.util.Collection;

import algorithm.Measurement;

public interface IAggregationStrategy {

	Measurement aggregate(Collection<Measurement> measurements);

}
