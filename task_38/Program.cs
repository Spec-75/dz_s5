// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.WriteLine("Enter the number of elements in the array");
int number = Convert.ToInt32(Console.ReadLine());

float[] array = new float[number];
int size = array.Length;
float maxArrayElement = 0;
float minArrayElement = 3.4e38f;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next();

    if (array[i] >= maxArrayElement) maxArrayElement = array[i];

    if (array[i] <= minArrayElement) minArrayElement = array[i];
}
Console.WriteLine($"maximum array element: {maxArrayElement}");
Console.WriteLine($"minimum array element: {minArrayElement}");
Console.WriteLine($"the difference between the maximum and minimum array elements: {maxArrayElement - minArrayElement}");
Console.WriteLine($"Source array: [{String.Join(", ", array)}]");