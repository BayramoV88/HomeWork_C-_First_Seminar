Console.Write("Введите первое число: ");
int number_a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number_b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number_c = Convert.ToInt32(Console.ReadLine());

if (number_a > number_b)
{
    if (number_a > number_c)
    {
        Console.WriteLine("Максимальное число " + number_a);
    }
    else
    {
        Console.WriteLine("Максимальное число " + number_c);
    }
}
else if (number_b > number_c)
{
    Console.WriteLine("Максимальное число " + number_b);
}
else
{
    Console.WriteLine("Максимальное число " + number_c);
}