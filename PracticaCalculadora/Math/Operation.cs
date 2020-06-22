using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticaCalculadora.Math
{
    public interface Operation
    {
        double Execute(double n1, double n2);
    }
}
