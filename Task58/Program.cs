
Console.Clear();

while (true)

{

int i=0;

int j=0;

int k=0;

float rand = 0;

float summ = 0;

Console.Write("Введите количество элементов массива M: ");

int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество элементов массива N: ");

int n = Convert.ToInt32(Console.ReadLine());


float[,] array1 = new float[m,n];

float[,] array2 = new float[m,n];

float[,] array3 = new float[m,n];

void InputArray(float[,] array1, float[,] array2)

{

for (j=0;j<n;j++)
 
{
  
for (i=0;i<m;i++)

{

rand = new Random().Next(-100,100)/10;

array1 [i,j]  = rand;

if (i==0)

{Console.Write("["+array1 [i,j]+", ");}

if (i!=0 && i!=m-1)

{Console.Write(array1 [i,j]+", ");}

if (i==m-1)

{Console.Write(array1 [i,j]+"] ");}

}

for (i=0;i<m;i++)

{

rand = new Random().Next(-100,100)/10;

array2 [i,j]  = rand;

if (i==0)

{Console.Write("["+array2 [i,j]+", ");}

if (i!=0 && i!=m-1)

{Console.Write(array2 [i,j]+", ");}

if (i==m-1)

{Console.WriteLine(array2 [i,j]+"] ");}

}

}

}

void ReleaseArray(float[,] array1, float[,] array2)

{

Console.WriteLine("Результирующая матрица:");

for (k=0;k<m;k++)

{

for (j=0;j<n;j++)

{

summ=0;

for (i=0;i<m;i++)

{

summ = summ + array1[i,j]*array2[k,i];

}

array3[k,j] = summ;

}

}


for (j=0;j<n;j++)
 
{
  
for (i=0;i<m;i++)

{

if (i==0)

{Console.Write("["+array3 [i,j]+", ");}

if (i!=0 && i!=m-1)

{Console.Write(array3 [i,j]+", ");}

if (i==m-1)

{Console.WriteLine(array3 [i,j]+"] ");}

}
}
}

InputArray(array1,array2);

ReleaseArray(array1,array2);

}
