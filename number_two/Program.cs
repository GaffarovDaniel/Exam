System.Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine()); // Замените значение M на нужное
System.Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine()); // Замените значение N на нужное

int sum = 0;

for (int i = M; i <= N; i++)
{
    sum += i;
}

 Console.WriteLine("Сумма натуральных чисел от " + M + " до " + N + " равна: " + sum);