using System.Collections;

namespace GraphProblems;

public class DepthFirstTraversal
{
    Dictionary<char, char[]> graph = new Dictionary<char, char[]>();
    Stack<char> stack = [];
    Queue<char> queue = [];
    public void DepthFirstTraversalIterative()
    {
        
        stack.Push('a');

        while (stack.Count > 0)
        {
            char curr = stack.Pop();
            Console.WriteLine(curr);
            char[] neibhours = graph[curr];
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
        char[] neibhours = graph[source];
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
            foreach (char n in graph[current])
            {
                queue.Enqueue(n);
            }
        }
    }

    private void GenerateGraph()
    {
        graph.Add('a', ['c', 'b']);
        graph.Add('b', ['d']);
        graph.Add('c', ['e']);
        graph.Add('d', ['f']);
        graph.Add('e', []);
        graph.Add('f', []);
    }
}
