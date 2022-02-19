using System;
using System.Collections.Generic;

namespace Polynomial
{
    class Program
    {

        static void Main(string[] args)
        {
            List<double> coef1 = new List<double>()
            {
                1, 2, 5
            };
            List<double> degree1 = new List<double>()
            {
                1, 1, 2
            };
            List<double> coef2 = new List<double>()
            {
                2, 4, 7
            };
            List<double> degree2 = new List<double>()
            {
                1, 2, 1
            };

            Polynomial polynomial1 = new Polynomial('x', coef1, degree1);
            Polynomial polynomial2 = new Polynomial('x', coef2, degree2);

            Console.WriteLine(polynomial1);
            Console.WriteLine(polynomial2);

            Console.WriteLine($"The result witn num for polinomial 1 is {polynomial1.CalculateForValue(2)}");

            Console.WriteLine($"Plus {polynomial1 + polynomial2}");
            Console.WriteLine($"Minus {polynomial1 - polynomial2}");
            Console.WriteLine($"Multiple {polynomial1 * polynomial2}");

            Console.ReadKey();
        }
    }
}


