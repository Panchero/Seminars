﻿/* Напишите программу, которая на вход принимает число и выдает его квадрат (число, умноженное на само себя)
Например:
3 -> 16
-3 -> 9
-7 -> 49
*/
Console.Clear();
Console.Write("Введите число и программа возведет его в квадрат:");
int n = Convert.ToInt32(Console.ReadLine()); // Конвертация из строки в тип данных Int
Console.WriteLine(n * n);