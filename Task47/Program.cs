Console.Clear();

while (true)

{


int i=0;

int j=0;

float rand = 0;

Console.Write("Введите количество элементов массива M: ");

int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество элементов массива N: ");

int n = Convert.ToInt32(Console.ReadLine());


double[,] array = new double[m,n];



void InputArray(double[,] array)

{

for (j=0;j<n;j++)

{
  

for (i=0;i<m;i++)

{

Random x = new Random();

rand = (1 - (float)x.NextDouble()*2)*10;  

array [i,j]  = Convert.ToDouble(Math.Round(rand,1));

if (i==0)

{Console.Write("["+array [i,j]+", ");}

if (i!=0 && i!=m-1)

{Console.Write(array [i,j]+", ");}

if (i==m-1)

{Console.WriteLine(array [i,j]+"]");}

}

}

}



InputArray(array);


}