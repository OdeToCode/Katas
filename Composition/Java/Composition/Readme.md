One day a developer was writing some logic to perform calculations on
a collection of Measurement objects with X and Y properties. The developer knew
the business would need different types of aggregations performed on the collection
(sometimes a simple sum, sometimes an average), and the business would also want
to filter measures (sometimes removing low values, sometimes removing high values).

The developer wanted to make sure all algorithms for calculating a result
would filter a collection of measurements before aggregation. After consulting
with a book on design patterns, the developer decided the Template Method pattern would be
ideal for enforcing a certain ordering on operations while still allowing subclasses to override
and change the actual filtering and the calculations.

	public abstract class PointsAggregator {

		protected Collection<Measurement> measurements;

		protected PointsAggregator(Collection<Measurement> measurements) {
			Measurements = measurements;
		}

		public Measurement Aggregate() {
			var measurements = Measurements;
			measurements = FilterMeasurements(measurements);
			return AggregateMeasurements(measurements);
		}

		protected abstract Collection<Measurement> FilterMeasurements(Collection<Measurement> measurements);
		protected abstract Measurement AggregateMeasurements(Collection<Measurement> measurements);

		public void setMeasurements(Collection<Measurement> measurements) {
			this.measurements = measurements;
		}

		public Collection<Measurement> getMeasurements() {
			return measurements;
		}

	}

From this base class the developer started creating different classes to represent
different calculations (along with unit tests).

Your job is to create a new calculation. A calculation to filter out measurements with low values
and then sum the X and Y values of the remaining measurements. You'll find details in the comments
of the code, and the unit tests.

You'll implement the calculation twice. Once by building on the
Template Method approach (in the Inheritance folder), and once with a compositional
approach (in the Composition folder).

!!How To Start!!

  1.	Run the tests using maven - `mvn test`

  3.	Start in the AggregationTests.java file from the algorithms.inheritance folder.
		Uncomment the last test in the file, and make it pass by building a
		HighPassSummingAggregator (there is already a placeholder for you in the Inheritance
		folder of the Algorithm project, you just
		have to figure out what class to inherit from and how to implement the logic).

  4.    Do the same in the Composition folder of the test project, using classes in
		the Composition folder of the Algorithm project.

  When you are finished and made all of the tests pass (9 total, you'll start with 6), take
  some time to reflect on the different approaches.

  Which are the drawbacks and benefits to each?

  Which one would you rather build on in the future?

  Which one achieves better "reusability"?




