using System;

class URI1009
{
    static void Main(string[] args)
    {
        string vendedor;
        double salario, vendas, salarioFinal;

        vendedor = Console.ReadLine();
        salario = double.Parse(Console.ReadLine());
        vendas = double.Parse(Console.ReadLine());

        salarioFinal = salario + (vendas * 0.15);
        Console.WriteLine("TOTAL = R$ " + salarioFinal.ToString("F2"));
    }
}