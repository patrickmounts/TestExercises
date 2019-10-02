using System;
using System.Linq;
using System.Text;

/// <summary>
/// given a string, reverse the string
/// </summary>
public static class ReverseString
{
    public static string ReverseStringWhile(string s)
    {
        StringBuilder sb = new StringBuilder();
        int Length = s.Length - 1;
        while (Length >= 0)
        {
            sb.Append(s[Length]);
            Length--;
        }
        return sb.ToString();
    }
    public static string ReverseStringLinqSimple(string s)
    {
        String sr = new string(s.Reverse().ToArray());
        return sr.ToString();
    }

    public static string ReverseStringLinq(string s)
    {
        string sr = s.Select(ch => ch.ToString())
                     .Aggregate<string>((xs, x) => x + xs);
        return sr;
    }

    public static string ReverseStringLinqPerformance(string s)
    {
        string sr = s.Aggregate(new StringBuilder(), (x, y) => x.Insert(0, y)).ToString();
        return sr;
    }

    public static string ReverseStringFor(string s)
    {
        int index = s.Length - 1;
        StringBuilder sb = new StringBuilder();

        for (int i = index; index >= 0; index--)
        {
            sb.Append(s.Substring(index, 1));
        }
        return sb.ToString();
    }

    public static string ReverseStringStack(string s)
    {
        Stack<char> ssr = new Stack<char>(s.Length);
        foreach (char c in s)
            ssr.Push(c);
        string revString = null;
        foreach (char c in s)
            revString += ssr.Pop();
        return revString;
    }
}
