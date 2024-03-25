using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems;

public class Problem151ReverseWordsInString
{
     
   
        public string ReverseWords(string s)
        {
            s = s.Trim();

            var sArray = s.Split(' ');
            Array.Reverse(sArray);

            var newString = "";

            for (int i = 0; i < sArray.Length; i++)
            {
                if (!(i == sArray.Length - 1) && !string.IsNullOrEmpty(sArray[i]))
                {
                    newString += sArray[i] + " ";
                }
                else
                {
                    newString += sArray[i];
                }
            }

            return newString;
        }
 
}
