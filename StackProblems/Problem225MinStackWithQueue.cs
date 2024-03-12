using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProblems;
 
public class Problem225MinStackWithQueue
{
    Queue<int> stack = [];
 

    public Problem225MinStackWithQueue()
    {
        stack = new Queue<int>();
        Push(1);
        Push(2);
        Push(3);
        Console.WriteLine(Pop());
        Console.WriteLine(Pop());
        Console.WriteLine(Pop());
        
        
        Console.WriteLine(Empty());
      
    }

    public void Push(int val)
    {
        int count = 0;
        while (count < stack.Count)
        {
            stack.Enqueue(stack.Dequeue());
            count++;
        }
      
       
            stack.Enqueue(val);
       
    }

    public int Pop()
    {
        int count = 0;
        while(count < stack.Count-1)
        {
            stack.Enqueue(stack.Dequeue());
            count++;
        }
        if (stack.Count > 0)
        {
           return stack.Dequeue();
        }
        return -1;

    }

    public int Top()
    {
        if (stack.Count == 0) return -1;

        return stack.Last();
    }

    public bool Empty()
    {
        return stack.Count == 0;
    }

}
