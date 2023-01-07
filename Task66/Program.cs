int rec (int a, int b)

{

    if (a == b)

        return b;

    return rec(a, b - 1) + b;

}

Console.Clear();

Console.Write("Введите значение M: ");

int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма натуральных чисел между "+ m +" и "+ n +" равна: " + rec (m , n));