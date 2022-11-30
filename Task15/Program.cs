Console.Clear();

while (true)

{

Console.Write ("Введите число N: ");

int n = Convert.ToInt32(Console.ReadLine());

string t="Не является днем недели";

int i = 1;

for (i = 1; i <= 7; i++)

{

if (n == i && n < 6  )     {t="Нет";}

if (n == i && n > 5  )     {t="Да";}

}

Console.WriteLine(t);

}
