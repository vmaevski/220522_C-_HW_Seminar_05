// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// *** Непарный элемент массива с нечётным кол-вом элементов будем выводить в конце нового массива.

int[] MultOfPairs(int[] array)
{
    int length = array.Length;
    int newLength = length / 2;
    if (length % 2 != 0)
    {
        newLength++; // для элемента без пары
    }
    int[] newArray = new int[newLength];
    for (int i = 0; i < length / 2; i++)
    {
        newArray[i] = array[i] * array[length - 1 - i];
    }
    if (length % 2 != 0)
    {
        newArray[newLength - 1] = array[newLength - 1]; // добавляем элемент без пары
    }
    return newArray;
}

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

int[] array = RandomArray(9, 1, 10);
PrintArray(array);
PrintArray(MultOfPairs(array));