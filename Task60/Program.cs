
Console.Clear();

while (true)

{

int i=0;

int j=0;

int k=0;

float rand = 0;

float med = 0;

Console.Write("Введите количество элементов массива L: ");

int l = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество элементов массива M: ");

int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество элементов массива N: ");

int n = Convert.ToInt32(Console.ReadLine());




float[,,] array = new float[l,m,n];


void InputArray(float[,,] array)

{

for (k=0;k<n;k++)
 
{

for (j=0;j<m;j++)
 
{
  
for (i=0;i<l;i++)

{

rand = new Random().Next(0,100);

array [i,j,k]  = rand;


}
}
}
}

void ReleaseArray(float[,,] array)

{

for (k=0;k<n;k++)
 
{

for (j=0;j<m;j++)
 
{
  
for (i=0;i<l;i++)

{

if (i==0)

{Console.Write("["+array [i,j,k]+"("+i+","+j+","+k+")"+", ");}

if (i!=0 && i!=l-1)

{Console.Write(array [i,j,k]+"("+i+","+j+","+k+")"+", ");}

if (i==l-1)

{Console.WriteLine(array [i,j,k]+"("+i+","+j+","+k+")"+"]");}
}
}
}


}


InputArray(array);

ReleaseArray(array);

}
