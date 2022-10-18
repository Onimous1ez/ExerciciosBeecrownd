namespace URI1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) * C / 2.0;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));
        }
    }
}