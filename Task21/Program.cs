Console.Clear();

while (true)

{

Console.Write ("Введите X1: ");

int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите Y1: ");

int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите Z1: ");

int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите X2: ");

int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите Y2: ");

int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите Z2: ");

int z2 = Convert.ToInt32(Console.ReadLine());

double G = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2));

Console.WriteLine ("Расстояние между точкой (" + x1 + "," + y1 + "," + z1 + ") и ("+ x2 + "," + y2 + "," + z2 + ")" + " Равно " + G + ".");

}