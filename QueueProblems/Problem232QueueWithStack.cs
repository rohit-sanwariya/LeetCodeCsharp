namespace QueueProblems;

public class Problem232QueueWithStack
{
    Stack<int> queue = new Stack<int>();
    public Problem232QueueWithStack()
    {
        queue = new Stack<int>();
        Push(1);
        Push(2);
        Console.WriteLine(Peek());
        Console.WriteLine(Pop());
    }

    public void Push(int x)
    {
        // 1,2,3,4,5 
        // 6,1,2,3,4,5
        queue.Push(x);
         
    }

    public int Pop()
    {
        // 1,2,3,4,5
        //  2,3,4,5
        int count = 0;
        while (count < queue.Count - 1)
        {
            queue.Push(queue.Pop());
            count++;
        }
        return queue.Count>0 ? queue.Pop() : -1;
    }

    public int Peek()
   {
     
        return queue.Count>0 ? queue.Peek(): -1;
   }

    public bool Empty()
    {
        return queue.Count == 0;
    }
}
