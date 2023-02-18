// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координту х первого числа");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координту y первого числа");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координту z первого числа");
double z1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координту x второго числа");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координту y второго числа");
double y2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координту z второго числа");
double z2 = double.Parse(Console.ReadLine()!);

double a = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.WriteLine($"a={a:f3}");
