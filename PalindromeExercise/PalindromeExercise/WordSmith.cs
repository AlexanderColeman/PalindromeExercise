using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string str)
        {
            string newString = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                newString += str[i];
            }

            return newString.ToLower() == str.ToLower();
        } 
    }
}
