using System.Collections.Generic;
using System.Text;

namespace ASP_recruitment
{
	public class Task2
	{
		public static string SortElements(string stringInput)
		{
			var inputArray = stringInput.Split(' ');
			var outputList = new List<string>();
			var maxValue = int.MaxValue;
			for (int i = 0; i < inputArray.Length; i++)
			{
				var digitValue = GetDigitValue(inputArray[i]);
				if (digitValue < maxValue)
				{
					maxValue = digitValue;
					outputList.Insert(0, inputArray[i]);
				}
				else
				{
					outputList.Add(inputArray[i]);
				}						
			}
			return string.Join(" ", outputList.ToArray());
		}

		private static int GetDigitValue(string word)
		{
			var strBuilder = new StringBuilder();
			for (int i = 0; i < word.Length; i++)
			{
				if (char.IsDigit(word[i]))
				{
					strBuilder.Append(word[i]);
				}
			}
			return int.Parse(strBuilder.ToString());
		}
	}
}