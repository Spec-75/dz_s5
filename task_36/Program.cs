// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Enter the number of elements in the array");
int number = Convert.ToInt32(Console.ReadLine());

int []array =new int[number];
int size = array.Length;
double sumOddElement = 0;
for (int i = 0; i< size; i++)
{
    array[i] = new Random().Next();

    if(i % 2 != 0)
    {
        sumOddElement += array[i];
    }
}

Console.WriteLine($"sum of odd array elements: {sumOddElement}");
Console.WriteLine($"Source array: [{String.Join(", ", array)}]");
