 

namespace ArrayProblems;

public class Problem11ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        int max = 0;
        int s = 0;
        int e = height.Length - 1;

        while (s <= e)
        {
            int w = e - s;
            int h = height[e] > height[s] ? height[s] : height[e];
            int a = w * h;
            if (a > max)
            {
                max = a;
            }
            if (height[e] > height[s])
            {
                s++;
            }
            else
            {
                e--;
            }
        }

        return max;
    }
}
