using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringProblems;

public class Problem316RemoveDuplicateChar
{
    public string RemoveDuplicateLetters(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        Stack<char> stack = new();
        foreach(char c in s)
        {
            if (dict.ContainsKey(c))
            {
                dict[c] += 1;
            }
            else
            {
                dict.TryAdd(c, 1);
            }
        }
        foreach(char c in s)
        {
            if (stack.Count == 0) {
                stack.Push(c);
                dict[c] = dict[c] - 1;
            }
            else
            {
                if(c > stack.Peek() && !stack.Contains(c))
                {
                    stack.Push(c);
                }
                else
                {
                    char current = stack.Peek();
                    while(stack.Count > 0 && dict[current] >  1 && c < current) {
                      
                        dict[current] = dict[current] - 1;
                        stack.Pop();
                        current = stack.Count  > 0 ? stack.Peek() : ' ';
                    }
                    if (!stack.Contains(c))
                    {
                        stack.Push(c);
                    }
                }
            }
        
        }
        return string.Join("", stack.Reverse());
    }
}
