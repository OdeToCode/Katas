package algorithm.inheritance;

import static org.junit.Assert.assertEquals;

import java.util.ArrayList;
import java.util.Collection;

import org.junit.Before;
import org.junit.Test;

import algorithm.Measurement;
import algorithm.inhereitance.AveragingAggregator;
import algorithm.inhereitance.LowPassAveragingAggregator;
import algorithm.inhereitance.SummingAggregator;

public class AggregationTest {

    	private Collection<Measurement> measurements;

    	@Before
    	public void setup() {
            measurements = new ArrayList<Measurement> () {{
                add(new Measurement(5,10));
                add(new Measurement(2, 15));
                add(new Measurement(100, 5));
            }};
    	}

	@Test
	public void SummingAggregation_Produces_Sum() {
		SummingAggregator aggregator = new SummingAggregator(measurements);

		Measurement result = aggregator.aggregate();

		assertEquals(107, result.getX());
		assertEquals(30, result.getY());
	}

	@Test
	public void AveragingAggregagtor_Produces_Average() {
		AveragingAggregator aggregator = new AveragingAggregator(measurements);

		Measurement result = aggregator.aggregate();

		assertEquals(35, result.getX());
		assertEquals(10, result.getY());
	}

	@Test
	public void LowPassAveragingAggregator_Applys_Filter() {
		LowPassAveragingAggregator aggregator = new LowPassAveragingAggregator(measurements);

		Measurement result = aggregator.aggregate();

		assertEquals(3, result.getX());
		assertEquals(12, result.getY());
	}

	/// Uncomment this test and make it pass reusing as much code as
	/// possible from other classes that are availalbe in the Inheritance folder
	//@Test
	//public void HighPassSummingAggregator_Applys_Filter() //{
	//    Aggregator aggregator = new HighPassSummingAggregator(measurements);

	//    Measurement result = aggregator.aggregate();

	//    assertEquals(105, result.getX());
	//    assertEquals(15, result.getY());
	//}

}
