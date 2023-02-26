Console.Write("Введите количество элементов массива: ");
int size1 = Convert.ToInt32(Console.ReadLine());

if(size1>0)
{
    string[] array1 = CreateArray1(size1);
    PrintArray(array1);
    
    Console.Write(" -> ");
    
    int size2 = SizeArray2Count(array1);
    
    string[] array2 = CreateArray2(array1,size2);
    PrintArray(array2);
}
else Console.WriteLine("Введено некорректное число: число элементов должно быть больше нуля.");

string[] CreateArray1(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите строку: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    if(arr.Length>0)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < arr.Length - 1) Console.Write($"\"{arr[i]}\", ");
            else Console.Write($"\"{arr[i]}\"]");
        }
    }
    else Console.Write("]");
}

int SizeArray2Count (string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length<=3) count++;
    }
    return count;
}

string[] CreateArray2(string[] arr, int size)
{
    string[] array = new string[size];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length<=3)
        {
            array[j]=arr[i];
            j++;
        }
    }
    return array;
}

