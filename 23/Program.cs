// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите положительное число:");
   int n = Convert.ToInt32(Console.ReadLine());
   if (n<1)
   {
    Console.Write("Введено не правильное число");
   }
   else
   {
   for (int i = 1; i <= n; i++)
   {
    int x = i*i*i;
    Console.Write(x + ",  ");
   }
   }
