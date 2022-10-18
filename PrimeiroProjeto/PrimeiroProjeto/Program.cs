using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Program{
        static void Main(string[] args){
            double x = 1.548945;
            int idade = 32;
            String nome = "Maria";
            char sexo = 'F';

            Console.WriteLine("Hello World");
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));

            Console.WriteLine("Resultado é: " + x);
            Console.WriteLine("Valor do troco: " + x + " reais");
            Console.WriteLine("Valor do troco: " + x.ToString("F2") + " reais");
            Console.WriteLine("A paciente " + nome + " tem " + idade + " anos e é do sexo " + sexo);

            Console.ReadLine();
        }
    }
}
