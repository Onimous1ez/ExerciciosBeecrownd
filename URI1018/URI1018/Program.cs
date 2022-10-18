namespace URI1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            int nota100 = N / 100;
            int resto100 = N % 100;

            int nota50 = resto100 / 50;
            int resto50 = resto100 % 50;

            int nota20 = resto50 / 20;
            int resto20 = resto50 % 20;

            int nota10 = resto20 / 10;
            int resto10 = resto20 % 10;

            int nota5 = resto10 / 5;
            int resto5 = resto10 % 5;

            int nota2 = resto5 / 2;
            int resto2 = resto5 % 2;

            int nota1 = resto2 / 1;
            int resto1 = resto2 % 1;

            Console.WriteLine(N);
            Console.WriteLine(nota100 + " nota(s) de R$ 100,00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50,00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20,00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10,00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5,00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2,00");
            Console.WriteLine(nota1 + " nota(s) de R$ 1,00");
        }
    }
}