﻿using System;

namespace EntradaDeDados2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo;");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa:");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre seu último nome, idade e altura:");
            string[] vet = Console.ReadLine().Split(' ');
            string uNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco + " reais");
            Console.WriteLine(uNome);
            Console.WriteLine(idade + " anos");
            Console.WriteLine(altura + " m");

            Console.ReadLine();
        }
    }
}
