using System;

namespace URI1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, raio;

            raio = double.Parse(Console.ReadLine());

            A = 3.14159 * (raio * raio);

            Console.WriteLine("A=" + A.ToString("F4"));
        }
    }
}
