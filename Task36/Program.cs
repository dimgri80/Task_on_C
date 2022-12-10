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
    
array[i] = new Random().Next(0,99);

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

int SumсNechet = 0;

for (i=0; i<array.Length; i++)

{if (i%2 != 0) {SumсNechet=SumсNechet+array[i];}}  

Console.WriteLine("Сумма нечетных чисел массива равна "+SumсNechet+".");
}

InputArray(array);

ReleaseArray(array);

}