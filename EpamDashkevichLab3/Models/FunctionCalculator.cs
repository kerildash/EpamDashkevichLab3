using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamDashkevichLab3.Models
{
    class FunctionCalculator
    {
        public double F(double x)
        {
            if(x >= -4 && x < -2)
            {
                return F(Functions.F1, x);
            } 
            else if (x >= -2 && x < 4)
            {
                return F(Functions.F2, x);
            }
            else if (x >= 4 && x < 6)
            {
                return F(Functions.F3, x);
            }
            else if (x >= 6 && x <= 10)
            {
                return F(Functions.F4, x);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            
        }
        private double F(Func<double, double> f, double x)
        {
            return f(x);
        }

    }
}
