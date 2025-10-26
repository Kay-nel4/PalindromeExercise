using System;
using System.Data.SqlTypes;
using System.Linq;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsPalindrome(string s)
    {
        char[] chars = s.ToCharArray();
        Array.Reverse(chars);
        string reversed = new string(chars);
        if (s == reversed)
        {
            return true;
        }
        return false;
    }
    
}