using System;
using System.Linq;

/// <summary>
/// Given a string determine if the string is a palindrome or not
/// a palindrome is a word that is the same forward as it is backwards e.g. tacocat
/// </summary>
public static class StringPalindrome
{
    //brute force solution
    public static bool IsPalindromeBrute(string s)
    {
        int i = 0;
        int j = s.Length - 1;
        while (true)
        {
            if (i > j)
            {
                return true;
            }
            char a = s[i];
            char b = s[j];
            if (char.ToLower(a) != char.ToLower(b))
            {
                return false;
            }
            i++;
            j--;
        }
    }

    //simple linq
    public static bool IsPalindromeLinq(string s)
    {
        return s.SequenceEqual(s.Reverse());
    }
}