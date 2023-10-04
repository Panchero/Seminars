/* 
Напишите программу, которая принимает 
на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8 
918 -> 1
*/

Console.Clear();
Console.Write("Введите трехзначное число и программа покажет его среднюю цифру: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n % 100 / 10);

// ------------------------------------- //

/*  
int n = new Random().Next(100,1000);
Console.WriteLine(n); // 523
int n1 = n /100; // 5
int n3 = n % 10; // 3
Console.WriteLine(n1 * 10 + n3);
*/