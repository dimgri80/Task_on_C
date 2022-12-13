

Console.Clear();

while (true)

{

int i=0;

Console.Write("Введите количество элементов массива: ");

int m = Convert.ToInt32(Console.ReadLine());

int[] array = new int[m];

void InputArray(int[] array)
{

for (i=0;i<m;i++)
{
Console.Write("Введите " +i+" элемент массива: ");

array[i]  = Convert.ToInt32(Console.ReadLine());

}


for (i=0;i<m;i++)
{
    
if (i==0)

{Console.Write("["+array [i]+", ");}

if (i!=0 && i!=m-1)

{Console.Write(array [i]+", ");}

if (i==m-1)

{Console.WriteLine(array [i]+"]");}

}
}

void ReleaseArray(int[] array)

{

int k=0;

for (i=0; i<m; i++)

{

if (array[i]>0) {k++;}


}  

Console.WriteLine("В массиве "+ k +" элемента больше ноля.");
}

InputArray(array);

ReleaseArray(array);

}