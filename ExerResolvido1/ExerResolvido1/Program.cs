using System;

namespace ExerResolvido1
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, area, precoMetroQuad, precoT;

            Console.WriteLine("Digite a largurado do terreno: ");
            largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do m^2: ");
            precoMetroQuad = double.Parse(Console.ReadLine());

            area = largura * comprimento;
            precoT = precoMetroQuad * area;

            Console.WriteLine("A area do terreno é de: " + area + " m");
            Console.WriteLine("O preço deste terreno é: " + precoT + " reais");

            Console.ReadLine();
        }
    }
}
