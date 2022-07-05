using System;
using Palindrome.Business_Logic;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "Madam, I'm Adam.";
            Console.WriteLine(PalindromeLogic.isThePhrasePalindrome(str));   
        }
    }
}
