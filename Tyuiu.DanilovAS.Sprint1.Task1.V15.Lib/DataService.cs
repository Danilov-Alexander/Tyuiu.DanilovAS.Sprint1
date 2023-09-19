using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DanilovAS.Sprint1.Task1.V15.Lib
{
    public class DataService : ISprint1Task1V15
    {
        public double Calculate(double x)
        {
            return (4 + 2 * x) / 7;
        }
    }
}
