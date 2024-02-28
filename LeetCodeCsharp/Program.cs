

using Recursion;
using StringProblems;
using Logical;
using ArrayProblems;
namespace LeetCodeCsharp;

internal class Program
{
    static void Main(string[] args)
    {
        PriorityQueue<char,int> priority = new PriorityQueue<char,int>();
        priority.Enqueue('c', 3);
        priority.TryDequeue(out char x, out int p);
        Console.WriteLine(x+" "+p);

        Problem162FindPeakElement temp = new ();
        Console.WriteLine( temp.FindPeakElement([11, 13, 15, 17]));

    }

   

   
}
