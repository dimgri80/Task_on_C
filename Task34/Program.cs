Console.Clear();

while (true)

{

int i=0;

Console.Write("Введите количество элементов массива: ");

int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

void InputArray(int[] array)

{
for (i=0;i<array.Length;i++)
{
    
array[i] = new Random().Next(100,999);

if (i==0)

{Console.Write("["+array [i]+",");}

if (i!=0 && i!=n-1)

{Console.Write(array [i]+",");}

if (i==n-1)

{Console.WriteLine(array [i]+"]");}

}
}

void ReleaseArray(int[] array)

{

int SumсChet = 0; 

int SumNechet = 0;

for (i=0; i<array.Length; i++)

if (array[i]%2 == 0) {SumсChet++;}  

else {SumNechet++;}

Console.WriteLine("В массиве "+SumсChet+" четных и "+SumNechet+" нечетных чисел.");
}



InputArray(array);
ReleaseArray(array);

}