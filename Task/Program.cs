string text = ReadStr("Введите символы через пробел: ");
char symbol = ' ';
string[] array1 = text.Split(symbol);
string[] array2 = new string[array1.Length];

LessThenThree(array1, array2);

Console.WriteLine("Массив из строк изначального массива, длина которых меньше, либо равна 3 символам:");
PrintArray(array2);

string ReadStr(string message)
{
    Console.WriteLine(message);
    string text = Console.ReadLine();
    return text;
}

void LessThenThree(string[] array1, string[] array2)
{
    int count = 0;
    int quantity = 3;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= quantity)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}