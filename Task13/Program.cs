Console.Clear();

while (true)

{

Console.Write ("Введите число N: ");

int n = Convert.ToInt32(Console.ReadLine());

int x = 1;

int i = 10;

int j = 0;

int m = 0;

int mi = 0;

while (x >= 1) 

{

x = n/i;

i=i*10;

j++;

mi = i/100;

}

i = 1;

if (j < 3) {Console.WriteLine ("Третье число отсутствует.");}

else  { 

while (i <= 3)

{

m = n/mi;

n=n-m*mi;

mi = mi / 10;

i++;

}

Console.WriteLine(m);

}

}