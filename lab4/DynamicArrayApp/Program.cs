// See https://aka.ms/new-console-template for more information

using DynamicArray;

DynamicArray<int> numbers = new DynamicArray<int>();
DynamicArray<Object> numbers2 = new DynamicArray<Object>(5);

Object obj = new Object();

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);

numbers2.Insert(0, obj);

Console.WriteLine("count: " + numbers.Count);

numbers.Insert(2, 100);
numbers.ChangeAt(1, 14);
Console.WriteLine("-----");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("-----");

Console.WriteLine("count: " + numbers.Count);

Console.WriteLine(numbers[2]);

numbers.Remove(5);

Console.WriteLine("count: " + numbers.Count);

numbers.RemoveAt(0);

Console.WriteLine("count: " + numbers.Count);

Console.WriteLine(numbers[0]);

int num = numbers.IndexOf(5);

Console.WriteLine(num);

Console.WriteLine();

Console.WriteLine("count: " + numbers.Count);

foreach (var num2 in numbers2)
{
    Console.WriteLine("----");
    Console.WriteLine(num2);
}

Console.WriteLine("count: " + numbers2.Count);

Console.WriteLine(numbers2[3]);

