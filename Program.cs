using System;
using System.Globalization;

namespace CsE13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCICIO 13
            Console.WriteLine("Determinado quadrante dos pontos\n\nINFORME VALOR X E Y: ");
            string[] vet = Console.ReadLine().Split(' ');
            double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vet[1], CultureInfo.InvariantCulture);
            Console.WriteLine($"\nX: {x}\nY: {y}");
            if (x > 0 && y > 0)
                Console.WriteLine("\nPONTOS NO QUADRANTE: Q1");
            else if (x > 0 && y < 0)
                Console.WriteLine("\nPONTOS NO QUADRANTE: Q4");
            else if (x < 0 && y > 0)
                Console.WriteLine("\nPONTOS NO QUADRANTE: Q2");
            else if (x < 0 && y < 0)
                Console.WriteLine("\nPONTOS NO QUADRANTE: Q3");
            else if (x == 0 && y == 0)
                Console.WriteLine("\nORIGEM");
            else if (x == 0)
                Console.WriteLine("\nEIXO Y");
            else if (y == 0)
                Console.WriteLine("\nEIXO X");
        }
    }
}
