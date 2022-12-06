Console.Clear();

while (true)

{

Console.Write ("Введите первое число: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе число: ");

int b = Convert.ToInt32(Console.ReadLine());

int i = 1;

int sum = 1;

for (i=1;i<=b;i++)

{sum = sum * a;}

Console.WriteLine("Число "+ a + " в степени "+ b + " равно " + sum +".");

}