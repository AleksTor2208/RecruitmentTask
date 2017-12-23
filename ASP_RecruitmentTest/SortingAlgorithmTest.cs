using NUnit.Framework;
using ASP_recruitment;

namespace ASP_RecruitmentTest
{
	[TestFixture]
	public class SortingAlgorithmTest
	{
		[Test]
		public void SortElementsMethod_ReturnProperValue()
		{
			//Arrange
			var unsortedVal = "wyraz12 wyraz3 wy21raz";
			var expected = "wyraz3 wyraz12 wy21raz";

			// Act
			var actual = SortingAlgorithm.SortElements(unsortedVal);
			
			//Assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void SortElementsMethod_ReturnProperValueWithArgHave5Words()
		{
			//Arrange
			var unsortedVal = "wyraz124 wyraz335 wy0raz 654wyraz 2wyrazy";
			var expected = "wy0raz 2wyrazy wyraz124 wyraz335 654wyraz";

			// Act
			var actual = SortingAlgorithm.SortElements(unsortedVal);

			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
