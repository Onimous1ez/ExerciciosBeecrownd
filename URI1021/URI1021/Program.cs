using System;

namespace URI1021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N;

            N = double.Parse(Console.ReadLine());

            double nota100 = N / 100;
            double resto100 = N % 100;

            double nota50 = resto100 / 50;
            double resto50 = resto100 % 50;

            double nota20 = resto50 / 20;
            double resto20 = resto50 % 20;

            double nota10 = resto20 / 10;
            double resto10 = resto20 % 10;

            double nota5 = resto10 / 5;
            double resto5 = resto10 % 5;

            double nota2 = resto5 / 2;
            double resto2 = resto5 % 2;

            double nota1 = resto2 / 1;
            double resto1 = resto2 % 1;

            double moeda2 = resto1 / 0.5;
            double restoMoeda2 = resto1 % 0.5;

            double moeda3 = restoMoeda2 / 0.25;
            double restoMoeda3 = restoMoeda2 % 0.25;

            double moeda4 = restoMoeda3 / 0.10;
            double restoMoeda4 = restoMoeda3 % 0.10;

            double moeda5 = restoMoeda4 / 0.05;
            double restoMoeda5 = restoMoeda4 % 0.05;

            double moeda6 = restoMoeda5 / 0.01;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(Math.Floor(nota100) + " nota(s) de R$ 100,00");
            Console.WriteLine(Math.Floor(nota50) + " nota(s) de R$ 50,00");
            Console.WriteLine(Math.Floor(nota20) + " nota(s) de R$ 20,00");
            Console.WriteLine(Math.Floor(nota10) + " nota(s) de R$ 10,00");
            Console.WriteLine(Math.Floor(nota5) + " nota(s) de R$ 5,00");
            Console.WriteLine(Math.Floor(nota2) + " nota(s) de R$ 2,00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(Math.Floor(nota1) + " moedas(s) de R$ 1,00");
            Console.WriteLine(Math.Floor(moeda2) + " moeda(s) de R$ 0,50");
            Console.WriteLine(Math.Floor(moeda3) + " moeda(s) de R$ 0,25");
            Console.WriteLine(Math.Floor(moeda4) + " moeda(s) de R$ 0,10");
            Console.WriteLine(Math.Floor(moeda5) + " moeda(s) de R$ 0,05");
            Console.WriteLine(Math.Floor(moeda6) + " moeda(s) de R$ 0,01");
        }
    }
}