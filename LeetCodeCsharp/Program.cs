

using Recursion;
using StringProblems;
using Logical;
using ArrayProblems;
namespace LeetCodeCsharp;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> temp = new List<int>();
        temp.Insert(0, 1);
        AddToFormArraySolution list = new();
        Console.WriteLine(String.Join(",", list.AddToArrayForm([2, 7, 4], 181)));
        Console.WriteLine(5/2);
    }
}
