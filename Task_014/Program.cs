/* 
Напишите программу, которая принимает на вход число
и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/

/* 
int n1 = 5;
int n2 = 10;

if (n1 == 5 && n2 == 10) // && - оператор "и "|| - оператор "или"
    Console.WriteLine("hi");
*/

Console.WriteLine("n = ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 7 == 0 && n % 23 == 0) // && - опиератор "и "|| - оператор "или"
    Console.WriteLine("yes");
else
    Console.WriteLine("no");