Console.Clear();

while (true)

{

Console.Write ("Введите число: ");

int l = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе число: ");

int m = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите третье число: ");

int n = Convert.ToInt32(Console.ReadLine());

if (l >= n && l >= m) 
{Console.WriteLine (l);}

else if (m >= n && m >= l) 
{Console.WriteLine (m);}

else if (n >= m && n >= l) 
{Console.WriteLine (n);}

}
