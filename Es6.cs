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

        for (int i = 0; i<N; i+=2)
        {
            if (i+1 < N)
            {
                (array[i], array[i + 1]) = (array[i+1], array[i]);
            }
        }

        WriteLine("\narray nuovo: ");
        for (int i = 0; i < N; i++)
        {
            Write(array[i] + ", ");
        }
    }
}
