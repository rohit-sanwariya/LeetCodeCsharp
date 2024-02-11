


namespace Blind75.Day1;

public class SlidingWindow
{
    public int maxProfit(int[] prices)
    {
        int max = 0;
        int buy =  0;
        int sell = 1;
       while(sell<prices.Length)
        {
            max = prices[sell] - prices[buy] > max ? prices[sell] - prices[buy] : max;
            if (prices[buy] > prices[sell])
            {
               
                buy = sell;

        
            }
           
               
                sell++;

         
        }

        return max;
    }
}
