package algorithm.composition;

import static org.junit.Assert.assertEquals;

import java.util.ArrayList;
import java.util.Collection;

import org.junit.Before;
import org.junit.Test;

import algorithm.Measurement;

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
        	PointsAggregator aggregator = new PointsAggregator(measurements, new EmptyFilter(), new SummingStrategy());

		Measurement result = aggregator.aggregate();

		assertEquals(107, result.getX());
		assertEquals(30, result.getY());
        }

        @Test
        public void AveragingAggregagtor_Produces_Average() {
		PointsAggregator aggregator = new PointsAggregator(measurements, new EmptyFilter(), new AveragingStrategy());

		Measurement result = aggregator.aggregate();

		assertEquals(35, result.getX());
		assertEquals(10, result.getY());
        }

        @Test
        public void LowPassAveragingAggregator_Applys_Filter() {
		PointsAggregator aggregator = new PointsAggregator(measurements, new LowPassFilter(), new AveragingStrategy());

		Measurement result = aggregator.aggregate();

		assertEquals(3, result.getX());
		assertEquals(12, result.getY());
        }

        // Uncomment this test and make it pass reusing as much code as
        // possible from other classes that are available in the Composition folder
        //@Test
        //public void HighPassSummingAggregator_Applys_Filter() {
        //    PointsAggregator aggregator = new PointsAggregator(measurements, new HighPassFilter(), new SummingStrategy());

        //    PointsAggregator result = aggregator.aggregate();

		// assertEquals(105, result.getX());
		// assertEquals(15, result.getY());
        //}

        /// Uncomment this test and make it pass by building a new class to
        /// hide the "composition" of strategies and filters ...
        //@Test
        //public void HighPassSummingAggregator_Applys_Filter() {
        //		HighPassSummingAggregator aggregator = new HighPassSummingAggregator(measurements);

        //		HighPassSummingAggregator result = aggregator.aggregate();

		//		assertEquals(105, result.getX());
		// assertEquals(15, result.getY());
        //}

}
