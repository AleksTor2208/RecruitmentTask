using ASP_recruitment;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_RecruitmentTest
{
    [TestFixture]
    public class Class1
    {
		[Test]
		public void TestTask1()
		{
			//Arrange
			var R = 148;
			var G = 0;
			var B = 211;
			var expected = "#9400D3";

			// Act
			var actual = Task1.ConvertToHexadecimal(R, G, B);

			//Assert
			Assert.AreEqual(expected, actual);
		}
    }
}
