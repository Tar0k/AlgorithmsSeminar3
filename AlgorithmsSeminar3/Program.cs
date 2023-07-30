using AlgorithmsSeminar3;


var linkedList = new MyLinkedList<string>();
//linkedList.AddInTail(1);
foreach (var number in Enumerable.Range(1, 10)) linkedList.AddInTail(number.ToString());

Console.Write("Сгенерированный связанный список: ");
Console.WriteLine(linkedList.ToString());
linkedList.Reverse();
Console.Write("Связанный список после разворота: ");
Console.WriteLine(linkedList.ToString());
