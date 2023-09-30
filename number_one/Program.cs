static void PrintNumbersFromNto1(int N)
{
    if (N >= 1)
    {
        Console.Write(N);
            if (N > 1)
                Console.Write(", ");
        PrintNumbersFromNto1(N - 1);
    }
}

Console.WriteLine("");
int N = Convert.ToInt32(Console.ReadLine()); // Замените значение N на нужное
PrintNumbersFromNto1(N);
