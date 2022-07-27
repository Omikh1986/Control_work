string[] StartArray = { "hello", "2", "world", ":-)", "1234", "-2"};
string[] FinalArray = new string[StartArray.Length];
for (int i = 0, j = 0; i < StartArray.Length; i++, j++)
{
    if (StartArray[i].Length <= 3)
    {
        FinalArray[j] = StartArray[i];
    }
    Console.Write($"{FinalArray[j]} ");
}

