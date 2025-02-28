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
            array[i] = random.Next(1, 10);
            Write(array[i] + ", \n");
        }

        bool palindromo = controllaPalindromo(array);

        WriteLine();
        WriteLine((palindromo ? "" : "non ") + "è pandomo");
    }

    static bool controllaPalindromo(int[] array)
    {
        for (int i = 0; i<array.Length/2; i++)
        {
            if (array[i] != array[array.Length - 1 - i])
                return false;
        }
        return true;
    }
}
