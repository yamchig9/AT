int[] Array = { 1, 2, 3, 4, 5 };

PrintArrayReversed(Array, Array.Length - 1);

void PrintArrayReversed(int[] arr, int index)
{
    if (index >= 0)
    {
        Console.Write($"{arr[index]} ");
        PrintArrayReversed(arr, index - 1);
    }
}