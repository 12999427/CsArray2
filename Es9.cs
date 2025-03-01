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

        //int[] array = {10, 20, 30, 40, 50};

        int[] output = new int[N];

        WriteLine("\nnuovo array: ");
        for (int i = 0; i < N; i++)
        {
            if (i == 0)
            {
                output[i] = (array[i] + array[i + 1]) / 2;
            }
            else if (i == N - 1)
            {
                output[i] = (array[i - 1] + array[i]) / 2;
            }
            else
            {
                output[i] = (array[i-1] + array[i] + array[i+1])/3;
            }
            Write(output[i] + ", ");
        }

    }
}
