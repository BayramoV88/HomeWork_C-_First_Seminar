Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int start = 1;
while (start <= number)
{
    if (start % 2 == 0)
    {
        Console.Write(start + " ");
        start++;
    }
    else
    {
        start++;
    }
}
Console.WriteLine();