using System;
using static System.Console;

public class Program
{
    public static void Main()
    {
        int N = 0;
        Random random = new Random(Environment.TickCount);
        do
        {
            WriteLine("inserisci N");
        } while (!int.TryParse(ReadLine(), out N) || N < 1);

        int[] array = new int[N];

        WriteLine("\narray: ");
        for (int i = 0; i < N; i++)
        {
            array[i] = random.Next(1, 101);
            Write(array[i] + ", ");
        }
        //int[] array = { 3, 5, 8, 2, 7, 9, 10, 4};

        int numseq = 1;
        int prev = int.MinValue;

        for (int i = 0; i < N; i++)
        {
            if (array[i] < prev)
            {
                numseq++;
                //WriteLine(">> " + i);
            }
            prev = array[i];
        }

        WriteLine($"Numero di sequenze: {numseq}");
    }
}
