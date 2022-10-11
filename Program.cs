void Fillarray(string[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = Convert.ToString(Console.ReadLine());                   //new Random().Next(-1000, 1001);
        index++;
    }
}
void PrintArray(string[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
       Console.WriteLine(col[position]);
       position++; 
    }
}