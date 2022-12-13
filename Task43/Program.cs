

Console.Clear();

while (true)

{

double x = 0;

Console.Write("Введите k1: ");

double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b1: ");

double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k2: ");

double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b2: ");

double b2 = Convert.ToInt32(Console.ReadLine());

while ((k1 * x + b1 != k2 * x + b2) ) 

{   
  
    if (k1 * -x + b1 == k2 * -x + b2) {x=-x-0.1;}

    x=x+0.1;
    
}

Console.WriteLine("Точка пересечения прямых имеет координаты ("+x+","+(k1 * x + b1)+").");

}