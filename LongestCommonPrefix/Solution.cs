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
		public string CheckForPrefixes(int lengthOfShortestString, string commonPrefix, int lengthOfStringArray, string[] strs, int inputIndex)
		{
			if (inputIndex == lengthOfShortestString)
			{
				return string.Empty;
			}

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
					if (commonPrefix == "")
					{
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
						string localCommonPrefix = CheckForPrefixes(lengthOfShortestString, commonPrefix, lengthOfStringArray, strs, inputIndex + 1);
					}
				}
				index++;
			}
			return commonPrefix;
		}
		public string LongestCommonPrefix(string[] strs) 
		{
			int lengthOfStringArray = strs.Length;
			int lengthOfShortestString = 0;
			foreach(string word in strs) 
			{
				int lengthOfWord = word.Length;
				if (lengthOfShortestString == 0) { lengthOfShortestString = lengthOfWord; }
				if (lengthOfShortestString != 0 && lengthOfWord < lengthOfShortestString) 
				{
					lengthOfShortestString = lengthOfWord;
				}
			}

			if (lengthOfStringArray > 0)
			{
				string thePrefix = CheckForPrefixes(lengthOfShortestString, "", lengthOfStringArray, strs, 0);
				return thePrefix;
			}
			return "";
		}
	}
}
