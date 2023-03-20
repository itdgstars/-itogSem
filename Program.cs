Console.Write("Введите желаемое количество слов: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] newArray = new string[length];
int num = 0; int str = 3;

for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Введите {i+1} слово: ");
    string word = Convert.ToString(Console.ReadLine());
    if (word.Length <= str)
    {
        newArray[num] = word;
        num++;
    }
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
ShowArray(newArray);