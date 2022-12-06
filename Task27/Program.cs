Console.Clear();

while (true)

{

Console.Write ("Введите число N: ");

int n = Convert.ToInt32(Console.ReadLine());

int x = 1;

int i = 10;

int j = 0;

int mi = 0;

while (x >= 1) 

{

x = n/i;

i=i*10;

j++;

mi = i/100;

}

Console.WriteLine("Число состоит из "+ j + " цифр.");

}