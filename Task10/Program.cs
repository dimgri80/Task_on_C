Console.Clear();

while (true)

{

Console.Write ("Введите число N: ");

int n = Convert.ToInt32(Console.ReadLine());

int m=(n/10)%10;

Console.WriteLine(m);
}