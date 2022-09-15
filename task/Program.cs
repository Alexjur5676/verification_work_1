// Задача: Написать программу, которая из имеющегося массива строк формирует новый 
// массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не 
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
}

Console.Write("Введите количество элементов в массиве ");
int amount = Convert.ToInt32(Console.ReadLine());

string[] arrayElements = new string[amount];
for (int i = 0; i < amount; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент: ");
    string symbol = Console.ReadLine()!;
    arrayElements[i] = symbol;
}

string[] arrayResult = new string[amount];
int length = 3;
int count = 0;

for (int i = 0; i < amount; i++)
{
    if (arrayElements[i].Length <= length)
    {
        arrayResult[count] = arrayElements[i];
        count++;
    }
}

Console.WriteLine();
PrintArray(arrayResult);