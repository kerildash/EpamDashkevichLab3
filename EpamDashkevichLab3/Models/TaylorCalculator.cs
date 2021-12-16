using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamDashkevichLab3.Models
{
    class TaylorCalculator
    {
        public double Calculate(double x, int n, int precisionPower, double sum)
        {            
            double term = 2 * Math.Pow(x, 2 * n + 1) / (2 * n + 1);
            sum += term;
            
            if (term < Math.Pow(10, precisionPower))
            {
                return sum;
            }
            else
            {
                return Calculate(x, n + 1, precisionPower, sum);
            }
            
        }
    }
}
