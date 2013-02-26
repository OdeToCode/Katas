package algorithm.composition;
import java.util.Collection;

import algorithm.Measurement;

public interface IMeasurementFilter {

	Collection<Measurement> filter(Collection<Measurement> measurements);

}
