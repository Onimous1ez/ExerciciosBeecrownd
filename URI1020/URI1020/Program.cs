namespace URI1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            int anos = N / 365;
            int restoAnos = N % 365;

            int meses = restoAnos / 30;
            int restoMeses = restoAnos % 30;

            int dias = restoMeses % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}