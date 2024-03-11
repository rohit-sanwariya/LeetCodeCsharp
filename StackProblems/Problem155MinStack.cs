namespace StackProblems;
internal class Node
{
    public int min { get; set; }
    public int val { get; set; }
    public Node(int val,int min)
    {
        this.min = min;
        this.val = val;
    }

}
public class Problem155MinStack
{
    Stack<Node> stack;
    int min = int.MaxValue;
    public Problem155MinStack()
    {
       stack = new();
       
    }

    public void Push(int val)
    {
        this.min = Math.Min(val, this.min);
        Node node = new Node(val, this.min);
        stack.Push(node);
    }

    public void Pop()
    {
        stack.Pop();
        this.min = stack.Peek().min;
    }

    public int Top()
    {
        return stack.Peek().val;
    }

    public int GetMin()
    {
        return this.min;
    }
}
