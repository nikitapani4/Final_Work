string[] Arr = {"1234", "1567", "-2", "computer science"};
int size = Arr.Length;
string[] NewArr = FillNewArray(Arr, size);

Console.WriteLine($"Первый массив --> {string.Join(" ", Arr)}");
Console.Write($"Второй массив --> {string.Join(" ", NewArr)}");



string[] FillNewArray(string[] array, int S)
{
    string[] newarray = new string[S];
    int j = 0;
    for(int i = 0; i < S; i++)
    {
        if(array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    return newarray;
}