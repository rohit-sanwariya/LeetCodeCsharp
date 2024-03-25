using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems;

public class Problem1897RedistributeCharacterstoMakeAllStringsEqual
{

    public bool MakeEqual(string[] words)
    {
        Dictionary<char, int> dict = new();
        foreach (string word in words)
        {
            foreach(char c in word)
            {
                if(dict.TryGetValue(c,out int value))
                {
                    dict[c] = value + 1;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
        }
        bool possible = false;
        foreach(var it in dict)
        {
           if(it.Value % words.Length != 0) { return false; }
        }

        return possible;
        
    }

}
