namespace AlgorithmsSeminar3;

public class MyLinkedList<T>
{
    private Node<T> Head { get; set; }
    private Node<T> Tail { get; set; }
    
    public MyLinkedList(T value)
    {
        var node = new Node<T>(value);
        Head = node;
        Tail = node;
    }

    public void AddInHead(T value)
    {
        var node = new Node<T>(value);
        node.Next = Head;
        Head.Previous = node;
        Head = node;
    }

    public void AddInTail(T value)
    {
        var node = new Node<T>(value);
        node.Previous = Tail;
        Tail.Next = node;
        Tail = node;
    }

    public void Reverse()
    {
        var node = Head;
        Head = Tail;
        while (node.Next != null)
        {
            (node.Next, node.Previous) = (node.Previous, node.Next);
            node = node.Previous;
        }
        (node.Next, node.Previous) = (node.Previous, node.Next);
        Tail = node;
    }
    

    public override string ToString()
    {
        var data = new List<string> { Head.Value?.ToString() ?? "null" };
        var nextNode = Head.Next; 
        while (nextNode != null)
        {
            data.Add(nextNode.Value?.ToString() ?? "null");
            nextNode = nextNode.Next;
        }

        return $"[{string.Join(", ", data)}]";
    }
    

}




public class Node<T>
{
    public Node(T value)
    {
        Value = value;
    }

    public T Value { get; set; }
    public Node<T>? Previous { get; set; }
    public Node<T>? Next { get; set; }
}