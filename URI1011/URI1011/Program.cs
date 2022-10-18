using System;

class URI1011
{
    static void Main(string[] args)
    {
        double R, pi = 3.14159, volume;

        R = double.Parse(Console.ReadLine());

        volume = (4.0 / 3.0) * pi * Math.Pow(R, 3.0);

        Console.WriteLine("VOLUME = " + volume.ToString("F3"));
    }
}