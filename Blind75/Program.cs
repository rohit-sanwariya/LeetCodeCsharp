using Blind75.Day1;
using Blind75.Day2_ContainsDuplicate;

namespace Blind75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem217ContainsDuplicate slide = new();
            Console.WriteLine(slide.ContainsDuplicate([1, 2, 3, 1]));
        }
    }
}
