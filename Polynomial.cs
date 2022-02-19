using System;
using System.Collections.Generic;
using System.Text;

namespace Polynomial
{
    class Polynomial
    {
        public Polynomial(char variable, List<double> coeficients, List<double> degree)
        {
            Variable = variable;
            Coeficients = coeficients;
            Degree = degree;
        }

        public Polynomial() { }

        char Variable { get; set; } = 'x';
        List<double> Coeficients { get; set; } = new List<double>();
        List<double> Degree { get; set; } = new List<double>();

        public double CalculateForValue(double value)
        {
            double result = 0;

            for (int i = 0; i < Coeficients.Count; i++)
            {
                result += Math.Pow(Coeficients[i] * value, Degree[i]);
            }

            return result; 
        }

        public static Polynomial operator +(Polynomial p1, Polynomial p2)
        {
            Polynomial p = new Polynomial();

            for (int i = 0; i < p1.Coeficients.Count; i++)
            {
                p.Coeficients.Add(p1.Coeficients[i] + p2.Coeficients[i]);
                p.Degree.Add(p1.Degree[i] + p2.Degree[i]);
            }

            return p;
        }

        public static Polynomial operator -(Polynomial p1, Polynomial p2)
        {
            Polynomial p = new Polynomial();

            for (int i = 0; i < p1.Coeficients.Count; i++)
            {
                p.Coeficients.Add(p1.Coeficients[i] - p2.Coeficients[i]);
                p.Degree.Add(p1.Degree[i] - p2.Degree[i]);
            }

            return p;
        }
        public static Polynomial operator *(Polynomial p1, Polynomial p2)
        {
            Polynomial p = new Polynomial();

            for (int i = 0; i < p1.Coeficients.Count; i++)
            {
                p.Coeficients.Add(p1.Coeficients[i] * p2.Coeficients[i]);
                p.Degree.Add(p1.Degree[i] * p2.Degree[i]);
            }

            return p;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < Degree.Count; i++)
            {
                if(Coeficients[i] < 0)
                {
                    builder.Append($"{Coeficients[i]}{Variable}^{Degree[i]}");
                }
                else
                    builder.Append($"+{Coeficients[i]}{Variable}^{Degree[i]}");
            }

            return builder.ToString();
        }
    }
}
