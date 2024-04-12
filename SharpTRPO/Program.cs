using System;

namespace TRPO
{
    class Program
    {
        static void Main() 
        {
            Console.Write("Введите количество элементов N = ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++) array[i] = int.Parse(Console.ReadLine());
            int Result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Result += array[i];
                }
                else
                {
                    Result -= array[i];
                }
            }
            Console.WriteLine("а) " + Result);
            Console.WriteLine("б) " + (array[0] + array[n-1]));
            Console.WriteLine("в) " + (array[0] - array[1]));
        }
    }
}