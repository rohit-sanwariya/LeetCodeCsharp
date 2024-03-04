using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem42TrappingRainWater
{
    public int Trap(int[] height)
    {

        int[] leftMax = new int[height.Length];
        int[] rightMax = new int[height.Length];
        int[] resultantMin = new int[height.Length];
        int max = int.MinValue;
        int sum = 0;
        for (int i=0;i<height.Length;i++)
        {
            if(height[i] > max)
            {
                max = height[i];
            }
            leftMax[i] = max;
        }
        max = int.MinValue;
        for (int i = height.Length-1; i >=0 ; i--)
        {
            if (height[i] > max)
            {
                max = height[i];
            }
            rightMax[i] = max;
        }
      
        for (int i = 0; i < height.Length; i++)
        {
            
            resultantMin[i] = Math.Min(leftMax[i], rightMax[i]);
        }
        for (int i = 0; i < height.Length; i++)
        {

            int val = resultantMin[i] - height[i];
            sum += val > 0 ? val : 0;
        }
      
        return sum;
    }
}
