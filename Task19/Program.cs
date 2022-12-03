Console.Clear();

while (true)

{

Console.Write ("Введите число: ");

int n = Convert.ToInt32(Console.ReadLine());

int i=1;
int j=0;
int x1=1;
int x2=0;
int k=1;
int m1=0;
int m2=10;

while (x1 >= 1)

{
x1 = n/i;
i=i*10;
j++;
}

m1 = i/100;


for (i=1; i < j/2; i++ )

{

x1=n/m1;

x2=n%m2;

n=(n-x1*m1)/10;

m1=m1/100;


if (x1 !=  x2)   {k=0;}
}


if (k == 1 ) 

{Console.WriteLine("Число - полиндром!");}

else

{Console.WriteLine("Число не является полиндромом!");}


}