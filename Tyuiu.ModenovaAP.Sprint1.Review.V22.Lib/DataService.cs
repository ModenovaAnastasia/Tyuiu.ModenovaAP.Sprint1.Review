using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ModenovaAP.Sprint1.Review.V22.Lib
{
    public class DataService : ISprint1Task7V22
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round(Math.Pow((1 - Math.Tan(x)), 1 / Math.Tan(x)) + Math.Cos(x - y), 3);
            return res;
        }
    }
}
