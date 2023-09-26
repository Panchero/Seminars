/* Напишите программу, которая будет выдавать название дня недели по его номеру
3 > среда
5 > пятница
*/

Console.Clear();
Console.WriteLine("Введите число и программа покажет название дня недели");
int a;
Console.Write("Введите число: ");
while (!int.TryParse(Console.ReadLine(), out a)) // Проверка на ввод целого числа
{
    Console.Write("Ошибка ввода! Введите число: "); // сообщение, когда условие не выполняется
}
if (a == 1)
{
    Console.WriteLine("Понедельник");
}
else if (a == 2)
{
    Console.WriteLine("Вторник");
}
else if (a == 3)
{
    Console.WriteLine("Среда");
}
else if (a == 4)
{
    Console.WriteLine("Четверг");
}
else if (a == 5)
{
    Console.WriteLine("Пятница");
}
else if (a == 6)
{
    Console.WriteLine("Суббота");
}
else if (a == 7)
{
    Console.WriteLine("Воскресенье");
}
else
{
    Console.WriteLine("Нет такого дня недели");
}