using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DanilovAS.Sprint1.Task3.V8.Lib
{
    public class DataService : ISprint1Task3V8
    {
        public double IncomeAmount(double percent, double timeDays)
        {
            return Math.Round(((percent / 100 * 2500) / 365) * timeDays + 2500,2);
        }
    }
}
