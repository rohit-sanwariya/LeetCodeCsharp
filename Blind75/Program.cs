using Blind75.Day1;

namespace Blind75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SlidingWindow slide = new();
            Console.WriteLine(slide.maxProfit([2, 4, 1]));
        }
    }
}
