string GetWordsStringArray(string[] array)
{
    string words = "\0";
    string wordsTwoSymbols = words;
    for (int i = 0; i < array.Length; i++)
    {
        words = array[i];
        if (words.Length < 3)
            wordsTwoSymbols += words + " ";
    }
    return wordsTwoSymbols;
}

string[] strArray = { "Привет", "он", "ко", "жесть" };
string ab = GetWordsStringArray(strArray);
System.Console.WriteLine($"{ab}");
//GetCharCount(ab);