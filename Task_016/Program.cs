/*

16. Напишите программу, которая принимает на вход два числа 
и проверяет, является ли одно число квадратом другого.
 
5,25 -> да
-4,16 -> 
да 25,5 ->
да 8,9 -> нет

*/

Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введиите втрое число: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 * n1 == n2 || n2 * n2 == n1) // && - оператор "и "|| - оператор "или"
    Console.WriteLine("Число явлеяется квадратом другого");
else
    Console.WriteLine("нет");

