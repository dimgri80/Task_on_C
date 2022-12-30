
Console.Clear();

while (true)

{

int i=0;

int j=0;

int k=0;

Console.Write("Введите количество элементов массива M: ");

int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество элементов массива N: ");

int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int [m,n];

void InputArray(int [,] array)

{

i=0;
j=0;


for (j=0;j<m;j++)
 
{
  
for (i=0;i<n;i++)

{

array[i,j]=0;

}
}




k=1;


for (int i = 0; i < m; i++) 
{
array[i,0] = k;
k++;
}

for (int j = 1; j < n; j++) 
{
array[n-1,j] = k;
k++;
}

for (int i = m-2; i >= 0; i--) 
{
array[i,n-1] = k;
k++;
}


for (int j = n-2; j >= 1; j--) 
{
array[0,j] = k;
k++;
}

for (int i = 1; i < m-1; i++) 
{
array[i,1] = k;
k++;
}


for (int j = 2; j < n-1; j++) 
{
array[n-2,j] = k;
k++;
}

for (int i = m-3; i > 0; i--) 
{
array[i,n-2] = k;
k++;
}




for (j=0;j<m;j++)
 
{
  
for (i=0;i<n;i++)

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



void ReleaseArray(int[,] array)

{


}

InputArray(array);

//ReleaseArray(array);

}
