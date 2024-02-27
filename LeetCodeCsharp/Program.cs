

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

        Problem153FindMinInSortedRotatedArray temp = new ();
        Console.WriteLine( temp.FindMin([11, 13, 15, 17]));

    }

   

   
}
