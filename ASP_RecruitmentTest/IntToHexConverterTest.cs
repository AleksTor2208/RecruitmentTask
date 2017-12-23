using ASP_recruitment;
using NUnit.Framework;

namespace ASP_RecruitmentTest
{
    [TestFixture]
    public class IntToHexConverterTest
    {
		[Test]
		public void ConvertToHexadecimal_ReturnProperStringValue()
		{
			//Arrange
			var R = 148;
			var G = 0;
			var B = 211;
			var expected = "#9400D3";

			// Act
			var actual = IntToHexConverter.ConvertToHexadecimal(R, G, B);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void ConvertToHexadecimal_ReturnCorrectValueWhenMaxValuesPassed()
		{
			//Arrange
			var R = 255;
			var G = 255;
			var B = 255;
			var expected = "#FFFFFF";

			// Act
			var actual = IntToHexConverter.ConvertToHexadecimal(R, G, B);

			//Assert
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void ConvertToHexadecimal_ReturnCorrectValueWhenMiddleValuesPassed()
		{
			//Arrange
			var R = 125;
			var G = 125;
			var B = 125;
			var expected = "#7D7D7D";

			// Act
			var actual = IntToHexConverter.ConvertToHexadecimal(R, G, B);

			//Assert
			Assert.AreEqual(expected, actual);
		}
	}
}
