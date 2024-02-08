

using Recursion;
using StringProblems;


namespace LeetCodeCsharp;

internal class Program
{
    static void Main(string[] args)
    {
        Anagram list = new();
        Console.WriteLine(list.CheckIFAnagram("racecar", "carrack"));
    }
}
