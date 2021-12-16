using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamDashkevichLab3.Models
{
    class Functions
    {
        static public double F1(double x)
        {
            return x + 3;
        }
        static public double F2(double x)
        {
            return -x / 2;
        }
        static public double F3(double x)
        {
            return -2;
        }
        static public double F4(double x)
        {
            if(x >= 6 && x <= 10)
            {
                return Math.Sqrt(4 - (x - 8) * (x - 8)) - 2;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
