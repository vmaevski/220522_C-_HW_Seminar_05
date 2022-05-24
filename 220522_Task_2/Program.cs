// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// *** Понял так, что нужно работать с элемнетами массива с нечётнымии ИНДЕКСАМИ (а не номерами по порядку).

int[] RandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
    }
    return array;
}

void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void PrintOddIndices(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 != 0)
        {
            Console.Write($"{array[i]} ");
        }     
    }
    Console.WriteLine();
}

int SumOfOddIndices(int[] array)
{
    int sum = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }     
    }
    return sum;
}

int[] array = RandomArray(8, 0, 9);
PrintArray(array);
PrintOddIndices(array);
Console.WriteLine(SumOfOddIndices(array));