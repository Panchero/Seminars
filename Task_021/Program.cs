﻿/*
Задача 21: Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между ними в 2D пространстве.
 
A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21

*/

Console.Write("Введите корординату по оси x первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите корординату по оси y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите корординату по оси x второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите корординату по оси y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

/*
Math.Sqrt - нахождение корня 
Math.POW - возведение в степень
Math.Round - округление до нужного количества знаков после запятой
*/

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
Console.WriteLine(Math.Round (d,2)); // можно перенсти в предыдущю строку