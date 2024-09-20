String? text1, text2;
HashSet<char> M1 = new HashSet<char>();
HashSet<char> M2 = new HashSet<char>();
Console.WriteLine("Введите первый текст: ");
text1 = Console.ReadLine();
CharsOfText(text1, M1);
Console.WriteLine("Введите второй текст: ");
text2 = Console.ReadLine();
CharsOfText(text2, M2);

M1.UnionWith(M2);
Console.WriteLine("Символы, которые встречаются в заданных двух текстах: ");
foreach(char c in M1)
{
    Console.Write(c);
    Console.Write(" ");
}
Console.WriteLine();

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
