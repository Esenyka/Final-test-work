Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
int i = 0;
int secondSize = 0;

Console.WriteLine("Введите элементы массива: ");
while(size != i)
{
    string elements = Console.ReadLine();
    if(elements.Length <= 3) secondSize++;
    array[i] = elements;
    i++;
}

string[] secondArray = new string[secondSize];
int count = 0;
while(size != count)
{
    if(array[count].Length <= 3)
    {
       secondArray[secondSize-1] = array[count];
       secondSize--;
    }
    count ++;
}

Console.Write($"[{string.Join(", ", array)}]");
Console.Write(" =====> ");
Console.Write($"[{string.Join(", ", secondArray)}]");
