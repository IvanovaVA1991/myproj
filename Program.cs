// решение задачи
string[] massiv = new string[5] { "hello", "new", "geekbrains", "41", "K" };
int len = FindArrayLength(massiv);
string[] newArray = NewArr(massiv, len);
PrintArray(newArray);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int FindArrayLength(string[] array)
{
    int len = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            len++;
        }
    }
    return len;
}
string[] NewArr(string[] massiv, int len)
{
    string[] newArr = new string[len];
    
    for (int i = 0; i < massiv.Length; i++)
    {
        for (int j = 0; j < len; j++)
        {
             if (massiv[i].Length < 4)
            {
                newArr[j] = massiv[i];
                j++;
            }
            i++;
        }
    }
    return newArr;
}
