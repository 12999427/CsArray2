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

        for (int i = 0; i < N; i++)
        {
            array[i] = random.Next(1, 21);
        }

        for (int i = 0; i < N; i++)
            WriteLine(array[i]);

        int[] quantita = new int[21];
        for (int i = 0; i < N; i++)
        {
            quantita[array[i]] += 1;
        }
        int max = 0;
        int elemMax = -1;
        for (int i = 0; i < 20; i++)
        {
            if (max < quantita[i])
            {
                max = quantita[i];
                elemMax = i;
            }
        }
        WriteLine($"il numero che compare di più è {elemMax} e compare {max} volte");
    }
}
