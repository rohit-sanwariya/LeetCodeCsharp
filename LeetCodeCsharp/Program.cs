

using Recursion;
using StringProblems;
using Logical;
using ArrayProblems;
namespace LeetCodeCsharp;

internal class Program
{
    static void Main(string[] args)
    { 
        Problem1464MaxProduct list = new();
        Console.WriteLine(String.Join(",", list.MaxProduct([3, 4, 5, 2])));
    }
}
