using System;
using System.Collections.Generic;
using System.Collections.Immutable;

/// <summary>
/// Given a string check if it is Pangram or not. A pangram is a sentence containing every letter in the English Alphabet.
/// Examples : The quick brown fox jumps over the lazy dog ” is a Pangram [Contains all the characters from ‘a’ to ‘z’]
/// </summary>
public static class StringPanGram
{    
    static readonly ImmutableHashSet<char> alphabet =
    ImmutableHashSet<char>.Empty.Union("abcdefghijklmnopqrstuvwxyz");
    static bool IsPangramSimple(string s)
    {
        return alphabet.Intersect(s.ToLower()).Count == alphabet.Count;
    }

    //Fastest implementation O(n)
    static HashSet<int> panaHash = new HashSet<int>();
    static int cI;
    static bool IsPangramQuick(string s)
    {
        panaHash.Clear();
        foreach (char c in s.ToLower())
        {
            cI = (int)c;
            if (cI < 97)   // not going to change in your life time 
                continue;
            if (cI > 122)  // not going to change in your life time 
                continue;
            panaHash.Add(cI);
            if (panaHash.Count == 26)
                return true;
        }
        return false;
    }
}
