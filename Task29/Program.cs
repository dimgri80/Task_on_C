Console.Clear();

while (true)

{

int i = 1;

int[] m = new int[8];

for (i=1;i<=8;i++)

{
    
Console.Write ("Введите "+i+" число массива: ");

m [i-1] = Convert.ToInt32(Console.ReadLine());  

}

for (i=1;i<=8;i++)

{
    
if (i==1)

{Console.Write("["+m [i-1]+",");}

if (i!=1 && i!=8)

{Console.Write(m [i-1]+",");}

if (i==8)

{Console.WriteLine(m [i-1]+"]");}

}
}