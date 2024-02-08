 

namespace Recursion;

public class Tribonacci
{
    Dictionary<int, int> dict = new();
    public Tribonacci()
    {
        dict.Add(1, 0);
        dict.Add(2, 1);
        dict.Add(3, 2);
    }
    public int TribonacciGenerator(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        if (n == 1 || n == 2)
        {
            return 1;
        }
        if (dict.TryGetValue(n, out int value))
        {
            return value;
        }
        int calc = TribonacciGenerator(n - 1) + TribonacciGenerator(n - 2) + TribonacciGenerator(n - 3);
        dict.TryAdd(n, calc);

        return calc;
    }
}
