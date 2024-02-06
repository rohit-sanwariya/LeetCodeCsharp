 

namespace Recursion;

public class Fibonacci
{
    private Dictionary<int, int> dict { get; set; } = [];
    public Fibonacci()
    {
        dict.Add(0, 0);
        dict.Add(1, 0);
        dict.Add(2, 1);
    }
    public int Fib(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        if (n == 1 || n == 2)
        {
            return 1;
        }
        if (dict.TryGetValue(n, out int result))
        {
            return result;
        }
        dict.TryAdd(n - 1, Fib(n - 1));
        return Fib(n - 1) + Fib(n - 2);
    }
}
