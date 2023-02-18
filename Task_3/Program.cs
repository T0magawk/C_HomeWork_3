// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//* при N < 0, нужно вывести от N до -1
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("Ведите число N:");
int n = int.Parse(Console.ReadLine()!);
int index = 1;
int index_ort = 0;
int a = 0;
Console.WriteLine($"кубы числе от 1 до {n}:");
if (n > 0)
{while (index <= n)
{
    a = index * index * index;
    Console.WriteLine(a);
    index = index + 1;
}
}
if (n < 0)
{
    index_ort = n;
    while (index_ort <= -1)
{
    a = index_ort * index_ort * index_ort;
    Console.WriteLine(a);
    index_ort = index_ort + 1;
}
}