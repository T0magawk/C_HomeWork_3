// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//* при N < 0, нужно вывести от N до -1
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("Ведите число N:");
int n = int.Parse(Console.ReadLine()!);
int index = 1;
int a = 0;
Console.WriteLine($"кубы числе от 1 до {n}:");
while (index <= n)
{
    a = index * index * index;
    Console.WriteLine(a);
    index = index + 1;
}

