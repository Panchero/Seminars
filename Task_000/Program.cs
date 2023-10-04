
int[] array = new int[8]; // массив цельночисленного типа, состоящий из восьми элементов
for (int i = 0; i < array.Length; i++) // начинаем с 0 , меньше длинны массива, добавляем по единице каждую итерацию
    array[i] = new Random().Next(-10, 11); // задаем рандомное значение от -10 до 10
Console.WriteLine($"[{string.Join(", ", array)}]"); //  функция объединяет массив в строку

for (int i = 0; i < array.Length; i++) // вывод массива через цикл
    Console.Write(array[i] + ", ");


/*
string name = "Rustem";
int age = 50;
string city = "Krasnodar";
Console.WriteLine($"Меня зовут {name} и мне {age} лет. Я из {city}"); // интерполяция строк
Console.WriteLine("Меня зовут " + name + " и мне " + age + " лет. Я из " + city);
*/