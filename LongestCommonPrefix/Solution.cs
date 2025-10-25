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
			if (lengthOfShortestString != 1 && inputIndex > lengthOfShortestString)
			{
				return (commonPrefix,false);
			}
			//if (lengthOfShortestString == 1)
			//{
			//	// might be the problem
			//	return (shortestWord,true);
			//}
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
				if (str.Length == 0)
				{
					commonPrefix = "";
					break;
				}

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
						if (inputIndex <= str.Length - 1)
						{
							commonPrefix = str.Substring(0, inputIndex);
							bools[index] = true;
						}
						else
						{
							if (str.Length == inputIndex)
							{
								commonPrefix = str.Substring(0, inputIndex);
								bools[index] = true;
							}
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
						// else bools[index] = false
						// it's false by default so no need to set it
					}
				}
				// last run loop through input strings
				if (index == lengthOfStringArray - 1)
				{
					// if any of the comparisons is false
					boolListHasFalse = bools.Contains(false);
					if (boolListHasFalse)
					{
						// remove one letter from commonPrefix, because not all words had this common prefix in this last round of testing
						commonPrefix = commonPrefix.Substring(0, commonPrefix.Length - 1);
						// no more matches
						break;
					}
					else
					{
						inputIndex++;
						// so far so good. Go for another letter in prefix
						(string,bool) commonPrefixResponse = CheckForPrefixes(shortestWord, lengthOfShortestString, commonPrefix, lengthOfStringArray, strs, inputIndex, boolListHasFalse);
						boolListHasFalse = commonPrefixResponse.Item2;
						if (inputIndex == lengthOfShortestString - 1)
						{
							return (commonPrefixResponse.Item1,boolListHasFalse);
						}
						else
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
			if (lengthOfStringArray == 0)
			{
				return "";
			}
			if (lengthOfStringArray == 1)
			{
				return strs[0];
			}
			int lengthOfShortestString = 0;
			string shortestWord = "";
			bool boolListHasFalse = false;
			// find shortest word
			foreach(string word in strs) 
			{
				int lengthOfWord = word.Length;
				if (lengthOfWord == 0)
				{
					shortestWord = word;
					lengthOfShortestString = lengthOfWord;
					break;
				}
				else if (lengthOfWord == 1)
				{
					shortestWord = word;
					lengthOfShortestString = lengthOfWord;
					break;
				}
				else
				{
					// if no shortest words have been recorded yet
					if (lengthOfShortestString == 0) { lengthOfShortestString = lengthOfWord; }
					// if no shortest word has been recorded yet
					if (shortestWord == "") { shortestWord = word; }
					// if record exists, check if this word is shorter
					if (lengthOfShortestString != 0 && lengthOfWord < lengthOfShortestString) 
					{
						// if shorter, it becomes shortest word
						lengthOfShortestString = lengthOfWord;
						shortestWord = word;
					}
					else
					{
						continue;
					}
				}
			}

			if (lengthOfStringArray > 0)
			{
				(string, bool) prefixResponse = CheckForPrefixes(shortestWord, lengthOfShortestString, "", lengthOfStringArray, strs, 0, boolListHasFalse);
				if (prefixResponse.Item1 != null && prefixResponse.Item1 != "" && prefixResponse.Item1.Length > 0) 
				{
					return prefixResponse.Item1;
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
