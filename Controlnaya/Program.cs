string[] strArray = { "Пт", "-2", ":)", "1112", "11", "Dj,", "Programming" }; // Введем случайный массив строк

// string[] strArray = { "hello", "2", "world", ":-)" };
//string[] strArray = { "1234", "1567", "-2", "computer science" };
//string[] strArray = { "Russia", "Denmark", "Kazan" };

string[] ab = GetWordsStringArray(strArray); // создадим массив, который формируется из метода выбора коротких значений по условию
System.Console.Write("[");
for (int i = 0; i < ab.Length; i++)
    System.Console.Write($" {ab[i]} ");
System.Console.WriteLine("]");

string[] GetWordsStringArray(string[] array)
{
    string word = "\0";
    int count = 0; // Переменная для создания нового массива строк
    for (int i = 0; i < array.Length; i++) 
    {
        word = array[i];
        if (word.Length <= 3)
        {
            count++; // подсчет вхождений для создания возвращаемого массива строк
        }
    }

    string[] finalArray = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        word = array[i];
        if (word.Length <= 3)
        {
            finalArray[count] = array[i];
            count++;
        }
    }
    return finalArray;
}