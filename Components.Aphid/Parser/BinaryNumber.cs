using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public static class BinaryNumber
    {
        public static decimal Parse(string number)
        {
            double d = 0;

            for (var x = number.Length - 1; x >= 0; x--)
            {
                if (number[x] == '1')
                {
                    var y = number.Length - x - 1;
                    d += Math.Pow(2, y);
                }
            }

            return (decimal)d;
        }
    }
}
