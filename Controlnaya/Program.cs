void GetCharCount(string array)
{

    string stringArray = array;
    char[] temp = new char[stringArray.Length];
    for (int i = 0; i < stringArray.Length; i++)
    {
        temp[i] = stringArray[i];
        Console.WriteLine($"{stringArray[i]} = {temp[i]}");
    }

}
//System.Console.WriteLine("Введите слова:");


string GetWordsStringArray(string[] array)
{
    string words = "\0";
    string wordsTwoSymbols = words;
    for (int i = 0; i < array.Length; i++)
    {
        words = array[i];
        if (words.Length < 3)
        {
            wordsTwoSymbols += words + " ";
        }
    }
    return wordsTwoSymbols;
}

string[] strArray = { "Привет", "он", "ко", "жесть" };
string ab = GetWordsStringArray(strArray);
System.Console.WriteLine($"{ab}");
//GetCharCount(ab);