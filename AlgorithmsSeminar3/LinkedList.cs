namespace AlgorithmsSeminar3;

public class MyLinkedList<T>
{
    public Node<T> Head { get; set; }
    public Node<T> Tail { get; set; }
    
    public MyLinkedList(Node<T> node)
    {
        Head = node;
        Tail = node;
    }

    public void AddInHead(Node<T> node)
    {
        node.Next = Head;
        Head.Previous = node;
        Head = node;
    }

    public void AddInTail(Node<T> node)
    {
        node.Previous = Tail;
        Tail.Next = node;
        Tail = node;
    }

    public void Reverse()
    {
        var node = Head;
        while (node.Next != null)
        {
            node = node.Next;
        }
        Head = node;

        while (node.Previous != null)
        {
            (node.Next, node.Previous) = (node.Previous, node.Next);
            node = node.Next;
        }
        (node.Next, node.Previous) = (node.Previous, node.Next);
        Tail = node;
    }
    

    public string Read()
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