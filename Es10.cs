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
            array[i] = random.Next(1, 11);
            Write(array[i] + ", ");
        }

        //int[] array = { 2, 4, 4, 4, 1, 5, 5, 3, 9, 9, 9, 0};

        int prev = -1;
        int inizio = -1;
        bool trovato = false;

        for (int i = 0; i < N; i++)
        {
            if (prev != array[i])
            {
                prev = array[i];
                inizio = i;
            }
            if (inizio == i-2)
            {
                WriteLine($"Valore trovato 3 volte: {prev} a partire da indice {inizio}");
                trovato = true;
            }
        }
        if (!trovato)
        {
            WriteLine("\nNon trovato");
        }
    }
}
