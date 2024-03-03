using System.Collections;

namespace GraphProblems;

public class DepthFirstTraversal
{
    Dictionary<char, char[]> dict = new Dictionary<char, char[]>();
    Stack<char> stack = [];
    Queue<char> queue = [];
    public void DepthFirstTraversalIterative()
    {
        
        stack.Push('a');

        while (stack.Count > 0)
        {
            char curr = stack.Pop();
            Console.WriteLine(curr);
            char[] neibhours = dict[curr];
            foreach (char n in neibhours)
            {
                stack.Push(n);
            }
        }
        // a,b,d
        // a,b,c
    }
    public DepthFirstTraversal()
    {
        GenerateGraph();
    }

    public void DepthFirstTraversalRecursive(char source='a')
    {
        Console.WriteLine(source);
        char[] neibhours = dict[source];
        foreach(char n in neibhours)
        {
            DepthFirstTraversalRecursive(n);
        }
    }  
    public void BreadthFirstTraversal(char source='a')
    {
        queue.Enqueue(source);
       
        while (queue.Count > 0)
        {
            char current = queue.Dequeue();
            Console.WriteLine(current);
            foreach (char n in dict[current])
            {
                queue.Enqueue(n);
            }
        }
    }

    private void GenerateGraph()
    {
        dict.Add('a', ['c', 'b']);
        dict.Add('b', ['d']);
        dict.Add('c', ['e']);
        dict.Add('d', ['f']);
        dict.Add('e', []);
        dict.Add('f', []);
    }
}
