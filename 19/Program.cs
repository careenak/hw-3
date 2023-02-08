// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число число:");
   int n = Convert.ToInt32(Console.ReadLine());
   if ((n<10000)||(n>99999))
   {
    Console.WriteLine("Число не пятизначное число");
   }
   else
   {
    int d1 = n/10000;
    int d2 = n%10;
    if (d1 == d2)
    {
        int d3 = n/1000-(d1*10);
        int d4 = (n/10)%10;
        if (d3 == d4)
        {
            Console.WriteLine("Число полиндром");
        }
        else
        {
            Console.WriteLine("Число не полиндром");
        }
    }
    else
    {
        Console.WriteLine("Число не полиндром");
    }
   }