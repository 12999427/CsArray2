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
            array[i] = random.Next(1, 101);
        }


        //Bubblesort(array, true, 0, N / 2);
        //Bubblesort(array, false, N / 2, N);

        SortArray(array, true, 0, N / 2);
        SortArray(array, false, N/2, N);


        for (int i = 0; i < N; i++)
        {
            WriteLine(array[i]);
        }
    }

    static void SortArray(int[] array, bool crescente, int startIndex, int endIndex)
    {
        while (!checkArray(array, crescente, startIndex, endIndex))
        {
            for (int i = startIndex; i < endIndex-1; i++)
            {
                if (crescente)
                {
                    if (array[i] > array[i + 1])
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                }
                else
                {
                    if (array[i] < array[i + 1])
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                }
            }
        }
    }

    static bool checkArray(int[] array, bool crescente, int startIndex, int endIndex)
    {
        int prev = crescente ? int.MinValue : int.MaxValue;
        for (int i = startIndex; i<endIndex; i++)
        {
            if (crescente)
            {
                if (prev > array[i])
                    return false;
            }
            else
            {
                if (prev < array[i])
                    return false;
            }
            prev = array[i];
        }
        return true;
    }

    static void Bubblesort(int[] array, bool crescente, int startIndex, int endIndex)
    {

        for (int i = startIndex; i < endIndex - 1; i++)
        {
            for (int j = startIndex; j < endIndex - i - 1 + startIndex; j++)
            {
                bool sonoInvertiti = false;
                if (crescente)
                {
                    sonoInvertiti = array[j] > array[j + 1];
                }
                else
                {
                    sonoInvertiti = array[j] < array[j + 1];
                }
                if (sonoInvertiti)
                {
                    /*int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;*/

                    //oppure tupla come in js

                    (array[j], array[j + 1]) = (array[j + 1], array[j]);

                }
            }
        }
    }
}
