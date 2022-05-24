// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

int[] RandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
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

int[] 1 MultOfPairs(int[] array)
{
    int length = array.Length;
    int newLength = length / 2; // если кол-во элементов массива нечётное, элемент из середины не имеет пары, его игнорируем.
    int[] newArray = new int[newLength]; 
    for (int i = 0; i < newLength; i++)
    {
        newArray[i] = array[i] * array[length - 1 - i];
    }
}

PrintArray(RandomArray(5, 1, 10));