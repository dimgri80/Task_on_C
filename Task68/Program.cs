int ack (int a, int b)

{

    if (a == 0)

        return b+1;

    else if ((a!=0)&&(b==0))

        return ack(a-1,1);

    else

        return ack(a-1,ack(a,b-1));

}

Console.Clear();

Console.Write("Введите значение M: ");

int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Функция Аккермана для чисел "+ m +" и "+ n +" равна: " + ack (m , n));