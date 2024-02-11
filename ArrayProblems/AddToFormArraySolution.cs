 

namespace ArrayProblems;

public class AddToFormArraySolution
{
    public IList<int> AddToArrayForm(int[] num, int k)
    {
      

        List<int> list = new();

        for(int i = num.Length -1 ; i >= 0; i--)
        {
            list.Insert(0, (num[i] + k)%10);
            k = (num[i] + k) / 10;
        }


        while (k > 0)
        {
            list.Insert(0,k%10);
            k /= 10;
        }
      

        return list;

    }
}
