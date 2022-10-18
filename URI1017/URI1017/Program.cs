using System;

namespace URI1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, Vmedia;
            double litros;

            tempo = int.Parse(Console.ReadLine());
            Vmedia = int.Parse(Console.ReadLine());

            litros = (tempo * Vmedia) / 12.0;

            Console.WriteLine(litros.ToString("F3"));
        }
    }
}
