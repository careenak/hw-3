// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("Введите координату x первого числа:");
   int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y первого числа:");
   int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z первого числа:");
   int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x второго числа:");
   int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y второго числа:");
   int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z второго числа:");
   int z2 = Convert.ToInt32(Console.ReadLine());
int x = x2 - x1;
int y = y2 - y1;
int z = z2 - z1;
double S = Math.Sqrt(x*x+y*y+z*z);
Console.Write("Расстояние между точками = "+S);