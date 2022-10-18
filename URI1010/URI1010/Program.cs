using System;

namespace URI1010
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorFinal;

            string[] vet1 = Console.ReadLine().Split(' ');
            int p1 = int.Parse(vet1[0]);
            int n1 = int.Parse(vet1[1]);
            double valor1 = double.Parse(vet1[2]);

            string[] vet2 = Console.ReadLine().Split(' ');
            int p2 = int.Parse(vet2[0]);
            int n2 = int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2]);

            valorFinal = n1 * valor1 + n2 * valor2;

            Console.WriteLine("VALOR A PAGAR: R$ " + valorFinal.ToString("F2"));
        }
    }
}
