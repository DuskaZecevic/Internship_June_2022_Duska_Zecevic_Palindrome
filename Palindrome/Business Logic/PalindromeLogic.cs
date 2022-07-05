using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Business_Logic
{
    public class PalindromeLogic
    {
        public static bool isThePhrasePalindrome(string str)
        {
            int start = 0;
            int length = str.Length-1;

            str = str.ToLower();

            while (start < length)
            {
                char char1 = str[start];
                char char2 = str[length];
                if (!(char1 >= 'a' && char1 <= 'z'))
                    start++;
                else if (!(char2 >= 'a' && char2 <= 'z'))
                    length--;
                else if (char1 == char2)
                { 
                    start++;
                    length--;
                }
                else return false;
            }
            return true;
        }
    }
}
