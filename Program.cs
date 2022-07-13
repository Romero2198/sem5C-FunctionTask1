int[] numbers = new int[4];
int count = 0;
FillArray(numbers);
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]%2 == 0)
    {
        count++;
    }
}
PrintArray(numbers);
Console.WriteLine($"-> {count}");

void FillArray(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
Console.WriteLine();
}