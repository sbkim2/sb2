using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPjt
{
    public class Calculator

    {

        public  double Add(double x, double y)

        {

            return x + y;

        }



        public double Divide(double x, double y)

        {

            if (y == 0)

            {

                throw new ArgumentException("Cannot divide by zero");

            }

            return x / y;

        }



        public double LimitedAdd(double x, double y, double minValue, double maxValue)

        {

            if (x > maxValue || x < minValue)

            {

                throw new ArgumentOutOfRangeException("x", $"x is outside the specified bounds");

            }



            if (y > maxValue || y < minValue)

            {

                throw new ArgumentOutOfRangeException("y", $"y is outside the specified bounds");

            }



            return x + y;

        }

    }
}
