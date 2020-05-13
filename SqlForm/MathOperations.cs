using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlForm
{
    public static class MathOperations
    {
        public static decimal Add(decimal x, decimal y) => x + y;

        public static decimal Divide(decimal x, decimal y)
        {
            if (y != 0.0m)
            {
                return x / y;
            }
            else
            {
                return 0.0m;
            }
        }
    }
}
