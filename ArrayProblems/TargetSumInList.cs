namespace ArrayProblems
{
    public class TargetSumInList
    {
        public TargetSumInList()
        {
           
           var tup = FindIndexesIfExist(new int[] {1,2,3,9,10},13);  
            Console.WriteLine(tup.Item1+" and "+tup.Item2);
        }

        public (int,int) FindIndexesIfExist(int[] list,int target)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();
            for (int i = 0; i < list.Length; i++)
            {
                if(dict.TryGetValue(list[i], out int index)) {
                    return (index, i);
                }
                dict.Add(target - list[i], i);
            }
            return   (1,1);
        }
    }
}
