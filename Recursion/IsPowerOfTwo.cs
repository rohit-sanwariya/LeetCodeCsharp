 
namespace Recursion;

public class IsPowerOfTwo
{
    public bool IsPowerOfTwoMethod(int n)
    {
        if (n <= 0)
        {
            return false;
        }
        if(n  == 1)
        {
            return true;
        }
        if (n % 2 == 0)
        {
            return IsPowerOfTwoMethod(n / 2);
        }
        else
        {
            return false;
        }
    }
}
