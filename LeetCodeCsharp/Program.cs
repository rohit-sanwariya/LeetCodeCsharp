

using Recursion;
using StringProblems;
using Logical;
using ArrayProblems;
using GraphProblems;
namespace LeetCodeCsharp;

internal class Program
{
    static void Main(string[] args)
    {
        int y;
        int refe = 5;

        PriorityQueue<char,int> priority = new PriorityQueue<char,int>();
        priority.Enqueue('c', 3);
        priority.Enqueue('d', 2);
        priority.TryDequeue(out char x, out int p);
        Console.WriteLine(x+" "+p);
        Problem42TrappingRainWater temp = new ();
        Console.WriteLine(temp.Trap([0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]));
        DepthFirstTraversal temp1 = new ();
        temp1.BreadthFirstTraversal();
        //Console.WriteLine( temp.SearchInsert([1, 3, 5, 6], 2));
        //myfun(out y, ref refe);
        //Console.WriteLine(y+" "+refe);

    }

    public  static void myfun(out int y, ref int z)
    {
        y = 3;
        z = 3;
        Console.WriteLine(y);
    }

   

   
}
