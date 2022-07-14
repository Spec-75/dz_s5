// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
//числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


Console.WriteLine("Enter the number of elements in the array");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
int size = array.Length;
int evenNumber = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000);

    if (array[i] % 2 == 0)
    {
        evenNumber++;
    }
}

Console.WriteLine($"number of even array elements: {evenNumber}");
Console.WriteLine($"Source array: [{String.Join(", ", array)}]");