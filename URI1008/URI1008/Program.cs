using System;

namespace URI1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUMBER, horas;
            double salario, salary;

            NUMBER = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            salario = double.Parse(Console.ReadLine());

            salary = horas * salario;

            Console.WriteLine("NUMBER = " + NUMBER);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2"));
        }
    }
}
