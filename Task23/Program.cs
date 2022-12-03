Console.Clear();

while (true)

{

Console.Write ("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());

int i = 1;

for (i=1;i<=n;i++)

{

if (i==n) {Console.WriteLine( Math.Pow(i,3) + ", ");}

else      {Console.Write( Math.Pow(i,3) + ", ");}

}

}