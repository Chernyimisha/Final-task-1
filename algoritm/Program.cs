Console.WriteLine("Введите количество элементов массива: ");
int size1 = Convert.ToInt32(Console.ReadLine());
string[] array1 = CreateArray1(size1);
PrintArray(array1);
int size2 = SizeArray2Count(array1);
string[] array2 = CreateArray2(array1,size2);
PrintArray(array2);

string[] CreateArray1(int num)
{
    string[] arr = new string[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write("Введите строку: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"\"{arr[i]}\", ");
        else Console.Write($"\"{arr[i]}\"]");
    }
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

