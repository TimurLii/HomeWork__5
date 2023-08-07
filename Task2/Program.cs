// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] array = GetArray(8, 2, 10);
Console.WriteLine($"[{String.Join(", ", array)}]");

int sum = 0;
int i = 1;
while (i < array.Length)
{
    sum += array[i];
    i += 2;
}
Console.WriteLine(sum);

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}