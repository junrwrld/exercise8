using System;
using System.Globalization;

namespace exercise8
{
    public class _exercise8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor:");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}