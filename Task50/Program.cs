
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


float[,] array = new float[m,n];


void InputArray(float[,] array)

{

for (j=0;j<n;j++)
 

{
  
for (i=0;i<m;i++)

{

rand = new Random().Next(-100,100)/10;

array [i,j]  = rand;

if (i==0)

{Console.Write("["+array [i,j]+", ");}

if (i!=0 && i!=m-1)

{Console.Write(array [i,j]+", ");}

if (i==m-1)

{Console.WriteLine(array [i,j]+"]");}

}

}

}

void ReleaseArray(float[,] array)

{

Console.Write("Введите номер элемента массива M: ");

int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер элемента массива N: ");

int n = Convert.ToInt32(Console.ReadLine());

if (m > i-1 || n > j-1) 

{Console.WriteLine("Элемент отсутствует в массиве.");}

else

{

Console.WriteLine(array [n,m]);

}

}



InputArray(array);

ReleaseArray(array);

}
