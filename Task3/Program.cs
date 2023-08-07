// Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3, 4, 1, 77, 65] => 77 - 1 = 76
int[] array = GetArray(5, 1, 99);
Console.WriteLine($"[{String.Join(",", array)}]");



int min = Int32.MaxValue;
int max = Int32.MinValue;
for (int i = 0; i < array.Length; i++)

{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine($"Максимальное значение {max},минимальное значение {min}. Разница равна {max - min}");



int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}