// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] array = GetArray(7, 100, 1000);
Console.WriteLine($"[{String.Join(", ", array)}]");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    count += array[i] % 2 == 0 ? 1 : 0;
}
Console.WriteLine(count);


int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}