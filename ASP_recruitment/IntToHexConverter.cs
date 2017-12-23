using System.Collections.Generic;
using System.Text;

namespace ASP_recruitment
{
	public class IntToHexConverter
	{
		static readonly Dictionary<string, string> HexValues = new Dictionary<string, string>
		{
			{ "10", "A" }, { "11", "B" }, { "12", "C" },
			{ "13", "D" }, { "14", "E" }, { "15", "F" }
		};

		public static string ConvertToHexadecimal(int r, int g, int b)
		{
			var strBuilder = new StringBuilder();
			strBuilder.Append(IntToHexadecimal(r));
			strBuilder.Append(IntToHexadecimal(g));
			strBuilder.Append(IntToHexadecimal(b));
			strBuilder.Insert(0, "#");
			return strBuilder.ToString();
		}

		private static string IntToHexadecimal(int value)
		{
			const int devider = 16;
			var strBuilder = new StringBuilder();
			if (value == 0) return "00";			
			while (value > 0)
			{
				strBuilder.Insert(0, value % devider);				
				value /= devider;
			}
			return AddLetters(strBuilder);		
		}

		private static string AddLetters(StringBuilder strBuilder)
		{
			var HexDecimalKeys = new List<string>(HexValues.Keys);
			var temp = strBuilder.ToString();
			for (int i = 0; i < temp.Length; i++)
			{
				if (i > temp.Length - 2) break;
		
				if (HexDecimalKeys.Contains(temp.Substring(i, 2)))
				{
					temp = HexValues[temp.Substring(i, 2)] + temp.Substring(i + 2, temp.Length-2);
				}
			}
			return temp;
		}		
	}
}