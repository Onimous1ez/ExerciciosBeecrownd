using System;

namespace URI1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, consumo;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());

            consumo = X / Y;

            Console.WriteLine(consumo.ToString("F3") + " km/l");
        }
    }
}
