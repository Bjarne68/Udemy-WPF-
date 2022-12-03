using CSharpePractise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpePractise.Classes
{
    public class SimpleMath:IInformation
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Add(double[] numbers)
        {
            double result = 0;
            foreach (double d in numbers)
            {
                result += d;
            }
            return result;
        }

        public string GetInformation()
        {
            return "Class that solves the simple math";
        }
    }
}
