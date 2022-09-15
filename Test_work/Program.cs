string[] Where(string[] array)
{
    int size = 0;
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= 3) size++;
    }
    string[] data = new string[size];
    int index = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= 3)
        {
            data[index] = array[i];
            index++;
        }
    }
    return data;
}

string[] arrStr = { "hello", "2", "world", "res", "75", "date" };
string[] arrData = Where(arrStr);
Console.WriteLine(string.Join(", ", arrData));
