// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// System.Console.WriteLine("Введите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if ((number > 9999) && (number < 100000))
// {
//     if ((number / 10000 == number % 10) && ((number / 1000) % 10 == (number / 10) % 10)) System.Console.WriteLine("Это число палиндром");
//     else System.Console.WriteLine("Это число не палиндром");
// }
// else System.Console.WriteLine("Это не пятизначное число");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// System.Console.WriteLine("Введите координаты первой точки:");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int z1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координаты второй точки:");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());
// double S = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
// System.Console.WriteLine($"Расстояние между точками = {Math.Round(S,2)}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// System.Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Кубы чисел от 1 до {number}");
// for (int i = 1; i <= number; i++)
// {
//     System.Console.Write($"{Math.Pow(i, 3)} ");
// }