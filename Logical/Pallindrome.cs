﻿namespace Logical
{
    public class Pallindrome
    {
        public bool IsPallindrome(int x)
        {
            if(x < 0)
            {
                return false;
            }
            int n = x;
            int rev = 0;
            while (n > 0) {      
                rev = rev * 10 + n % 10;
                n /= 10;
            }
            return rev == x;
        }
    }
}
