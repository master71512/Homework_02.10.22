﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.WriteLine("Введите коэффициенты 1-го уравнения y = kx + b");
Console.Write("k = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициенты 2-го уравнения y = kx + b");
Console.Write("k = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b = ");
double b2 = Convert.ToDouble(Console.ReadLine());
if (k1 == k2)
{
    if (b1 == b2) Console.WriteLine("прямые совпадают");
    else Console.WriteLine("прямые параллельны");
}
else
{
    Console.WriteLine($"прямые пересекаются в точке ({(b2 - b1) / (k1 - k2)}; {k1 * (b2 - b1) / (k1 - k2) + b1})");
}