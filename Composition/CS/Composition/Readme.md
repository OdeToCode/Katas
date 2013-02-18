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

	public abstract class PointsAggregator
	{
		protected PointsAggregator(IEnumerable<Measurement> measurements)
		{
			Measurements = measurements;
		}
	
		public virtual Measurement Aggregate()
		{
			var measurements = Measurements;
			measurements = FilterMeasurements(measurements);
			return AggregateMeasurements(measurements);
		}
	
		protected abstract IEnumerable<Measurement> FilterMeasurements(IEnumerable<Measurement> measurements);
		protected abstract Measurement AggregateMeasurements(IEnumerable<Measurement> measurements);
			
		protected readonly IEnumerable<Measurement> Measurements;
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

  1.	Open the solution file. 

  2.	Run the tests to make sure everything is in working order.
		Note: you'll need to use an xUnit.net test runner. 
		
		R# users can get xunitcontrib-resharper from http://xunitcontrib.codeplex.com/
		
		Or, you can use the xUnit runner for Visual Studio 2012 http://visualstudiogallery.msdn.microsoft.com/463c5987-f82b-46c8-a97e-b1cde42b9099
		
		Or, you can download xUnit from http://xunit.codeplex.com/releases/view/77573.
		Once you've unblocked and extracted the files, run xunit.gui.exe.

  3.	Start in the AggregationTests.cs file from the Algorithm.Tests.Inheritance folder.
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



 
