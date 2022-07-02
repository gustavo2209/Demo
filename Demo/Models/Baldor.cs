using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class Baldor
    {
        public double Suma(params double[] v)
        {
            double sum = 0d;

            for(int i = 0; i < v.Length; i++)
            {
                sum += v[i];
            }

            return sum;
        }

        public double Resta(double a, double b)
        {
            double c = a - b;

            return c;
        }

        public double Multiplica(double a, double b)
        {
            double c = a * b;

            return c;
        }

        public double Divide(double a, double b)
        {
            double c = a / b;

            return c;
        }
    }
}