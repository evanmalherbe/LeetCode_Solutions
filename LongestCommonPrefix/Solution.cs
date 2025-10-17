using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
	public class Solution
	{
		public string CheckForPrefixes(int lengthOfStringArray, string[] strs)
		{
			string commonPrefix = "";
			int index = 0;
			// Set inital values of bool array
			List<bool> bools = new List<bool>() { false , false, false};
			// check for common prefix
			foreach (string str in strs) 
			{
				if (index == 0)
				{
					// initial prefix
					char[] chars = str.ToCharArray();
					commonPrefix = chars[0].ToString();
					bools[index] = true;
				}
				else 
				{
					// compare next string's prefix with initial one
					int prefixLength = commonPrefix.Length;
					if (prefixLength > 0) 
					{
						string subString = str.Substring(0, prefixLength);
						if (subString == commonPrefix) 
						{
							bools[index] = true;
						}
					}
				}
				if (index == lengthOfStringArray - 1)
				{
					bool boolListHasFalse = bools.Contains(false);
					if (boolListHasFalse)
					{
						// no more matches
						break;
					}
					else
					{
						// so far so good. Go for another letter in prefix
						string localCommonPrefix = CheckForPrefixes(lengthOfStringArray, strs);
						commonPrefix = localCommonPrefix;
					}
				}
				index++;
			}
			return commonPrefix;
		}
		public string LongestCommonPrefix(string[] strs) 
		{
			int lengthOfStringArray = strs.Length;
			if (lengthOfStringArray > 0)
			{
				string thePrefix = CheckForPrefixes(lengthOfStringArray, strs);
				return thePrefix;
			}
			return "";
		}
	}
}
