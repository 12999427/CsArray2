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
            array[i] = random.Next(1, 51);
            Write(array[i] + ", ");
        }

        int prev = array[0];
        for (int i = N-1; i >= 0; i--)
        {
            (array[i], prev) = (prev, array[i]);
        }

        WriteLine("\narray nuovo: ");
        for (int i = 0; i < N; i++)
        {
            Write(array[i] + ", ");
        }
    }
}
