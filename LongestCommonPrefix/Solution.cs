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
		public (string,bool) CheckForPrefixes(string shortestWord, int lengthOfShortestString, string commonPrefix, int lengthOfStringArray, string[] strs, int inputIndex, bool boolListHasFalse)
		{
			if (boolListHasFalse)
			{
				return (commonPrefix, true);
			}
			if (lengthOfShortestString != 1 && inputIndex  == lengthOfShortestString - 1)
			{
				return (string.Empty,false);
			}
			if (lengthOfShortestString == 1)
			{
				return (shortestWord,true);
			}
			int index = 0;
			// Set inital values of bool array
			List<bool> bools = new List<bool>();
			foreach(string word in strs)
			{
				bools.Add(false);
			}
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
						// if common prefix is no longer "", but index is 0, try adding another letter to prefix
						if ((inputIndex + 1) <= str.Length)
						{
							commonPrefix = str.Substring(0, inputIndex + 1);
							bools[index] = true;
						}
					}
				}
				else 
				{
					// compare next string's prefix with initial one
					int prefixLength = commonPrefix.Length;
					if (prefixLength > 0 && prefixLength <= str.Length) 
					{
						string subString = str.Substring(0, prefixLength);
						if (subString == commonPrefix) 
						{
							if (index <= strs.Length - 1)
							{
								bools[index] = true;
							}	
						}
					}
				}
				// last run loop through input strings
				if (index == lengthOfStringArray - 1)
				{
					boolListHasFalse = bools.Contains(false);
					if (boolListHasFalse)
					{
						// no more matches
						break;
					}
					else
					{
						if (boolListHasFalse)
						{
							return (commonPrefix,boolListHasFalse);
						}
						// so far so good. Go for another letter in prefix
						(string,bool) commonPrefixResponse = CheckForPrefixes(shortestWord, lengthOfShortestString, commonPrefix, lengthOfStringArray, strs, inputIndex + 1, boolListHasFalse);
						boolListHasFalse = commonPrefixResponse.Item2;
						if (boolListHasFalse)
						{
							return (commonPrefixResponse.Item1,boolListHasFalse);
						}
					}
				}
				index++;
			}
			return (commonPrefix,boolListHasFalse);
		}
		public string LongestCommonPrefix(string[] strs) 
		{
			int lengthOfStringArray = strs.Length;
			if (lengthOfStringArray == 0 || strs.Any(i => i == ""))
			{
				return "";
			}
			int lengthOfShortestString = 0;
			string shortestWord = "";
			bool boolListHasFalse = false;
			// find shortest word
			foreach(string word in strs) 
			{
				int lengthOfWord = word.Length;
				if (lengthOfWord == 1)
				{
					shortestWord = word;
					lengthOfShortestString = lengthOfWord;
					break;
				}
				else
				{
					if (lengthOfShortestString == 0) { lengthOfShortestString = lengthOfWord; }
					if (lengthOfShortestString != 0 && lengthOfWord < lengthOfShortestString) 
					{
						lengthOfShortestString = lengthOfWord;
					}
					else
					{
						break;
					}
				}
			}

			if (lengthOfStringArray > 0)
			{
				(string, bool) prefixResponse = CheckForPrefixes(shortestWord, lengthOfShortestString, "", lengthOfStringArray, strs, 0, boolListHasFalse);
				if (prefixResponse.Item1 != null && prefixResponse.Item1 != "" && prefixResponse.Item1.Length > 0) 
				{
					string finalPrefix = prefixResponse.Item1.Length != 1 
						? prefixResponse.Item1.Substring(0, prefixResponse.Item1.Length - 1)
						: prefixResponse.Item1;
					return finalPrefix;
				}
				else
				{
					return "";
				}
			}
			return "";
		 }
	}
}
