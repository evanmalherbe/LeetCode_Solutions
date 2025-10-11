using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
	public class Solution
	{
		public bool IsPalindrome(int x)
		{
			// x = 121
			// output = true
			string initialStringOfX = x.ToString();
			char[] charArray = initialStringOfX.ToCharArray();
			if (charArray.Length == 1) 
			{
				return true;
			}
			List<char> reverseCharArray = new List<char>();
			for (int i = charArray.Length - 1; i >= 0; i--) 
			{
				var t = charArray[i];
				reverseCharArray.Add(charArray[i]);
			}
			string reversedString = string.Join("", reverseCharArray);

			if (initialStringOfX == reversedString)
			{
				 return true;
			}

			return false;
		}
	}
}
