using System.Collections.Generic;
using System.Text;

namespace ASP_recruitment
{
	public class SortingAlgorithm
	{
		// Task # 2
		public static string SortStrByDigits(string stringInput)
		{
			var stringDict = new Dictionary<int, string>();
			var inputArray = stringInput.Split(' ');
			for (int i = 0; i < inputArray.Length; i++)
			{
				stringDict.Add(GetDigitValue(inputArray[i]), inputArray[i]);
			}
			var stringDictKeys = new List<int>(stringDict.Keys);
			stringDictKeys.Sort();
			var outputArray = new string[stringDictKeys.Count];
			for (int i = 0; i < outputArray.Length; i++)
			{
				outputArray[i] = stringDict[stringDictKeys[i]];
			}
			return string.Join(" ", outputArray);
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