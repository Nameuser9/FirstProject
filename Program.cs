void Fillarray(string[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = Convert.ToString(Console.ReadLine());                   //Ввод слов в массив
        index++;
    }
}
void PrintArray(string[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        if (col[position].Length < 4)   //Выводится слова которые короче 4 симбволов
        {
       Console.WriteLine(col[position]);
        }
       position++; 
    }
}
Console.WriteLine("введите сколько слов будет в текстовом массиве");
int m =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводите слова");
string[] array = new string[m];
Fillarray(array);
Console.WriteLine("Слова из 3 и менее симбволов");
PrintArray(array);