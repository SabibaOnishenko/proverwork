string[] array = new string[]{"world","2","hello",";)"};
Console.WriteLine("В поиске участвуют");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

Console.WriteLine();
Console.WriteLine("Отображаем все слова, в которых 3 или менее символов");
 for (int i = 0; i < array.Length; i++)
 {
    if (array[i].Length <= 3)
    {
        Console.WriteLine(array[i]);
    }
 }
