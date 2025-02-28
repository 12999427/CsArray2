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

        int[] somme = new int[(int)Math.Ceiling(N/2.0)];

        /*for (int i = 1; i<N; i+=2) //metodo semplice x non rischiare di accedere a elementi fuori ma non fa la somma ultima se len è dispari
        {
            somme[i/2] = array[i] + array[i-1];
        }*/

        //oppure

        int j = 0;
        for (int i = 0; i < N; i += 2)
        {
            if (i+1 < array.Length)
            {
                somme[j] = array[i] + array[i + 1];
            } else
            {
                somme[j] = array[i];
            }
            j++;
        }


        WriteLine("\nsomme: ");
        for (int i = 0; i<somme.Length; i++)
        {
            Write(somme[i] + ", ");
        }
    }
}
