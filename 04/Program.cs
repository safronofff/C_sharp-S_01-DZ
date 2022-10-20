Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

for (int y = 1; y <= x; y++)
	if (y % 2 == 0)
	{
		Console.WriteLine(y);
	}