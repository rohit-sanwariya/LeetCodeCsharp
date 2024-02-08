
namespace StringProblems
{
    public class Anagram
    {
        public bool CheckIFAnagram(string first, string second)
        {
    
            int[] arrfirst = new int[256];
            int[] arrSecond = new int[256];

            Array.Clear(arrfirst, 0, 256);
            Array.Clear(arrSecond, 0, 256);

            if(first.Length != second.Length)
            {
                return false;
            }

            for (int i = 0; i < first.Length; i++)
            {
                arrfirst[first[i]] += 1;
                arrSecond[second[i]] += 1;
            } 
            
            for (int i = 0; i < 256; i++)
            {
                if (arrfirst[i] != arrSecond[i])
                {
                    return false;
                }
            }

                
          
            return true;
        }
    }
}
