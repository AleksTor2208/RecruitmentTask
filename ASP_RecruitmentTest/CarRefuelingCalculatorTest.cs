using ASP_recruitment;
using NUnit.Framework;

namespace ASP_RecruitmentTest
{
	[TestFixture]
	public class CarRefuelingCalculatorTest
	{
		readonly int[] cars = { 1, 4, 7, 2, 10, 15, 8 };

		[Test]
		public void TimeCountMethod_ReturnProperValueWhenTwoPumpsPassed()
		{
			//Arrange
			var pumps = 2;
			var expected = "25";

			// Act
			var actual = CarRefuelingCalculator.TimeCount(cars, pumps);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void TimeCountMethod_ReturnProperValueWhenThreePumpsPassed()
		{
			//Arrange
			var pumps = 3;
			var expected = "17";

			// Act
			var actual = CarRefuelingCalculator.TimeCount(cars, pumps);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void TimeCountMethod_ReturnProperValueWhenFourPumpsPassed()
		{
			//Arrange
			var pumps = 4;
			var expected = "15";

			// Act
			var actual = CarRefuelingCalculator.TimeCount(cars, pumps);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void TimeCountMethod_ReturnProperValueWhenFivePumpsPassed()
		{
			//Arrange
			var pumps = 5;
			var expected = "15";

			// Act
			var actual = CarRefuelingCalculator.TimeCount(cars, pumps);

			//Assert
			Assert.AreEqual(expected, actual);
		}

	}
}
