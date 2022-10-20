Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
	Console.WriteLine($"max:{a}, min{b}");
}
else
{
	Console.WriteLine($"max:{b}, min{a}");
}