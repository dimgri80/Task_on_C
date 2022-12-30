
Console.Clear();

while (true)

{

int i=0;

int j=0;

int k=0;

float temp = 0;

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

Console.WriteLine("Массив после сортировки:");

//Сортировка массива:

  
for (j=0;j<n;j++)

{

k=0;

while (k<m)

{

for (i=0;i<m-1;i++)

{
    
if (array [i,j] < array [i+1,j]) 

{
    temp =  array [i+1,j];

    array [i+1,j] = array [i,j];

    array [i,j] = temp;
    
}
}
k++;
}
}


// вывод отсортированного массива

for (j=0;j<n;j++)
 
{
  
for (i=0;i<m;i++)

{

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

ReleaseArray(array);

}

