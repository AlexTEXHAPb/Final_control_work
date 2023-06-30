string[] array = new string[9]
{ "Привет!", "Mой", "родной", "мир", ":-)", "Я", "и", "ты", "вместе!" };
int k = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
    if (array[i].Length <= 3)
    {
        array[k] = array[i];
        k++;
    }
}
Console.WriteLine();
string[] newarray = new string[k];
for (int i = 0; i < k; i++)
{
    newarray[i] = array[i];
    Console.Write($"{newarray[i]} ");
}