using System;
using System.Collections.Generic;

namespace Practise
{
    public class CyclicalFigurateNumbers
    {
        public void demo()
        {
            var numbs = new List<double>();
            var chain = new List<double>();
        }

        public bool isCircular(string a, string b)
        {
            string a1 = a[0] + a[1] + "";
            string a2 = a[2] + a[3] + "";

            string b1 = b[0] + b[1] + "";
            string b2 = b[2] + b[3] + "";


            if (a2 == b1)
                return true;
            else if (b2 == a1)
                return true;
            else
                return false;


        }
        public bool isSquare(double val)
        {
            double res = Math.Sqrt(val);
            if (res % 1 == 0)
                return true;

            return false;
        }
        public bool isTriangular(double val)
        {
            double no = (8 * val) + 1;
            double res = Math.Sqrt(val);
            if (no % 2 != 0)
            {
                if (res % 1 == 0)
                    return true;
            }
            return false;
        }


        public bool isPentagonal(double val)
        {
            double a = (24 * val) + 1;
            double b = Math.Sqrt(a);

            if (b % 1 == 0)
                return true;
            return false;
        }

        public bool isHexagonal(double val)
        {
            double b = Math.Sqrt((val*8)+1);

            if (b % 1 == 0)
            {
                if((b+1) % 4 == 0)
                    return true;
            }
                
            return false;


        }
        public bool isHeptagonal(double val)
        {
            double a = ((20 * val) + 3)/2;
            double b = Math.Sqrt(a);

            if (b % 1 == 0)
                return true;
            return false;


        }
    }
}