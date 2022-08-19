// у всех эл-тов массива поменять знак на противоположный.

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
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] ResignArray(int[] array)
{
    
    for(int i = 0; i < array.Length; i++)
        array[i] = -1 * array[i] ;
    
    return array;
} 

int[] array = CreateArray(7, -14, 6);
PrintArray(array);
ResignArray(array);
PrintArray(array);