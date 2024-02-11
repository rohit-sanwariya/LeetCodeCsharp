 

namespace Logical;

public class WaterBottle
{
    public int  numWaterBottles(int numBottles,int numExchange)
    {
        int final = numBottles;

        while(numBottles / numExchange >= 1)
        {
            int d = numBottles / numExchange;
            final += d;
            numBottles = d + numBottles%numExchange;

        }

        return final;
    }
}
