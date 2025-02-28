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
        int Ncorrente = 0;
        for (int i = 0; i < N; i++)
        {
            do
            {
                Ncorrente = random.Next(1, N + 2);
            } while (presente(array, Ncorrente));

            array[i] = Ncorrente;
        }

        for (int i = 0; i < N; ++i)
        {
            WriteLine(i + ": " + array[i] + ", ");
        }

        //somma
        int somma = 0;
        for (int i = 0; i<N; i++)
        {
            somma += array[i];
        }
        int sommatot = (N + 1) * (N + 2) / 2;
        int numMancante = sommatot - somma;

        WriteLine("Num mancante: " + numMancante);
    }

    static bool presente(int[] array, int elemento)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == elemento)
                return true;
        }
        return false;
    }
}
