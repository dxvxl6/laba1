﻿Console.WriteLine("Введите а");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите c");
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите х");
double x = Convert.ToDouble(Console.ReadLine());
double y = a * (x * x) + b * x + c;
Console.WriteLine($"Значение y ={y}");