
int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}


void FindElementsNumber(int[] array)
{
    int number = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99)
            {
                number++;
            }
    }

    Console.WriteLine($"В диапазоне [10; 99] {number} элементов массива");
}


int[] array = CreateArray(123, -54, 154);
FindElementsNumber(array);