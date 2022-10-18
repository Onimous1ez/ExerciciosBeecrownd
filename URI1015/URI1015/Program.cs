namespace URI1015
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] valores = Console.ReadLine().Split(' ');
            double x1 = double.Parse(valores[0]);
            double y1 = double.Parse(valores[1]);

            valores = Console.ReadLine().Split(' ');
            double x2 = double.Parse(valores[0]);
            double y2 = double.Parse(valores[1]);

            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));

            Console.WriteLine(distancia.ToString("F4"));
        }
    }
}