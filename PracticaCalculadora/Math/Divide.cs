using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaCalculadora.Math
{
    public class Divide : Operation
    {
        public double Execute(double x, double y)
        {
            if (y == 0)
            {
                return 99999;
            }

            double result = x / y;
            return result;
        }
    }
}
