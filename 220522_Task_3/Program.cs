// 3. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] RandomArray(int length, int minValue, int maxValue)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(minValue, maxValue + 1)) / Convert.ToDouble(new Random().Next(1, 10));
    }
    return array;
}

void PrintArray(double[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{Math.Round(array[i], 2)} ");
    }
    Console.WriteLine();
}

void DiffMaxMin(double[] array)
{
    double Diff;
    double minNum = array[0];
    double maxNum = array[0];
    int length = array.Length;
    for (int i = 1; i < length; i++)
    {
        if (array[i] < minNum)
        {
            minNum = array[i];
        }
        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
    }
    Diff = maxNum - minNum;    
    Console.WriteLine($"({Math.Round(maxNum, 2)}) - ({Math.Round(minNum, 2)}) = {Math.Round(Diff, 2)}");
}

double[] array = RandomArray(10, -100, 100);
PrintArray(array);
DiffMaxMin(array);
