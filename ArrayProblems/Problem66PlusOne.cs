using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem66PlusOne
{
    public int[] PlusOne(int[] digits)
    {
        int last = digits.Length - 1;
        int carry = 0;
        digits[last] = digits[last] + 1;
        while (last >=0)
        {
            digits[last] = digits[last]+carry;
            if (digits[last] < 10)
            {
                return digits;
            }
            else
            {
                int temp = digits[last];
                carry = temp / 10;
                digits[last] = temp % 10;
                last--;
            }
        }
        if (carry > 0)
        {
            Array.Resize(ref  digits, digits.Length+1);
            digits[0] = carry;
        }
        return digits;
    }
}
