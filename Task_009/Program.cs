/*  Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа.
78 -> 8 
12 -> 2 
85 -> 8 */

int n = new Random().Next(10, 100); // [10,99]
int n1 = n / 10;
int n2 = n % 10;
Console.WriteLine(n);

if (n1 > n2)
    Console.WriteLine(n1);
else
    Console.WriteLine(n2);