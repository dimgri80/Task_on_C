

Console.Clear();

while (true)

{

int i=0;

Console.Write("Введите количество элементов массива: ");

int n = Convert.ToInt32(Console.ReadLine());



float[] array = new float[n];

void InputArray(float[] array)
{

Random rand = new Random();

for (i=0;i<array.Length;i++)
{
    
array[i] = (float)rand.NextDouble()*100;

if (i==0)

{Console.Write("["+array [i]+", ");}

if (i!=0 && i!=n-1)

{Console.Write(array [i]+", ");}

if (i==n-1)

{Console.WriteLine(array [i]+"]");}

}
}

void ReleaseArray(float[] array)

{

float max = array[0];

float min = array[0];

for (i=0; i<array.Length-1; i++)

{

if (array[i+1]>max) {max=array[i+1];}
    
if (array[i+1]<min) {min=array[i+1];}    

}  

Console.WriteLine("Разница максимального и минимального чисел массива равна "+(max-min)+".");
}

InputArray(array);

ReleaseArray(array);

}