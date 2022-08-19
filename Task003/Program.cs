

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
    Console.WriteLine();
}


void FindNumberInArray(int[] array)
{
    Console.WriteLine("Введите любое целое число");
    int number = Convert.ToInt32(Console.ReadLine());
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
        {
            Console.WriteLine($"В данном массиве есть число {number}");
            return;
        }
    }
    
        Console.WriteLine($"В данном массиве нет числа {number}");
}

int[] array = CreateArray(10, -18, 132);
PrintArray(array);
FindNumberInArray(array);