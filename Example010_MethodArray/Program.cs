int[] array = { 1, 12, 31, 43, 55, 66, 55, 78, 89 };

int n = array.Length;
int find = 55;

int index = 0;

while (index < n)
{
        if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}