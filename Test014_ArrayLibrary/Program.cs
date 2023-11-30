
void FillArray(int[] collection) // метод для наполнения массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col) // метод для вывода на печать массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + "\t");
        position++;
    }
}

int IndexOf(int[] collect, int find)  // метод для нахождения индекса искомого элемента в массиве
{
    int count = collect.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collect[index] == find)
        {
            position = index;
            break;  // прерываем цикл при первом нахождении искомого аргумента
        }
        index++;
    }
    return position;
}

int [] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
