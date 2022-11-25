Console.Clear();

while (true)
{
Console.Write ("Введите первое число: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе число: ");

int m = Convert.ToInt32(Console.ReadLine());

if (n > m) 
{Console.WriteLine (n + " > " + m);}

else if (n < m) 
{Console.WriteLine (m + " > " + n);}
}

