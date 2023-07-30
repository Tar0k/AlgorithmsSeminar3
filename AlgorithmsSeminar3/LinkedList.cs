namespace AlgorithmsSeminar3;

public class MyLinkedList<T>
{
    private Node<T>? Head { get; set; }
    private Node<T>? Tail { get; set; }

    public void AddInHead(T value)
    {
        var node = new Node<T>(value);
        // Первый элемент
        if (Head == null)
        {
            Head = node;
            Tail = node;
            return;
        }
        
        node.Next = Head;
        Head.Previous = node;
        Head = node;
    }

    public void AddInTail(T value)
    {
        var node = new Node<T>(value);
        // Первый элемент
        if (Head == null)
        {
            Head = node;
            Tail = node;
            return;
        }
        
        node.Previous = Tail;
        Tail.Next = node;
        Tail = node;
    }

    public void Reverse()
    {
        if (Head?.Next == null) return;
        
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
        if (Head == null) return "[]";
        
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