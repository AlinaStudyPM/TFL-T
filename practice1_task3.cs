String? text;
HashSet<char> M = new HashSet<char>();
Console.WriteLine("Введите текст: ");
text = Console.ReadLine();
CharsOfText(text, M);

Console.Write("Количество различных символов в тексте: ");
Console.WriteLine(M.Count());

//Функция, составляющая на основе строки множество символов
void CharsOfText(String? text, HashSet<Char> M)
{
    if(text != null)
    {
        foreach(char c in text)
        {
            M.Add(c);
        }
    }
}
