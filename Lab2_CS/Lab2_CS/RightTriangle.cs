using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_CS
{
    public class RightTriangle : Triangle
    {
         public bool IsRightTriangle()
        {
            base.IsTriangle();
            if (StringA * StringA + StringB * StringB == StringC * StringC || StringC * StringC + StringB * StringB == StringA * StringA || StringA * StringA + StringC * StringC == StringB * StringB)
            {
                return (true);
            }
            return (false);
        }
    }
}
