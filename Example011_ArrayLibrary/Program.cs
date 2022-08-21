void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] collection2)
{
    int count = collection2.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collection2[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position; 
}

int[] array = new int[10]; //new int[10] означает "создай новый массив, в котором будет 10 элементов"

FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 400);
Console.WriteLine(pos);
