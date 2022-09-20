string Prompt(string message)
{
    System.Console.Write(message);
    string result = Console.ReadLine();
    return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}