using AlgorithmsSeminar3;

var firstNode = new Node<string>("1");
var linkedList = new MyLinkedList<string>(firstNode);

foreach (var number in Enumerable.Range(2, 9))
{
    var newNode = new Node<string>(number.ToString());
    linkedList.AddInTail(newNode);
}
Console.Write("Сгенерированный связанный список: ");
Console.WriteLine(linkedList.Read());
linkedList.Reverse();
Console.Write("Связанный список после разворота: ");
Console.WriteLine(linkedList.Read());
