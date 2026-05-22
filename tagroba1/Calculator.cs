using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tagroba1
{
    public class Calculator
    {
        public string total1(int x, int y, int z)
        {
            int X=Convert.ToInt32(x)*15;
            int Y = Convert.ToInt32(y)*10;
            int Z = Convert.ToInt32(z) * 50;
            return Convert.ToString(X + Y + Z);
        }
        public string total2(int x, int y, int z)
        {
            int X = Convert.ToInt32(x) * 20;
            int Y = Convert.ToInt32(y) * 25;
            int Z = Convert.ToInt32(z) * 80;
            return Convert.ToString(X + Y + Z);
        }
        public string total3(int x, int y, int z)
        {
            int X = Convert.ToInt32(x) * 5;
            int Y = Convert.ToInt32(y) * 10;
            int Z = Convert.ToInt32(z) * 25;
            return Convert.ToString(X + Y + Z);
        }
        public string total4(int x, int y, int z)
        {
            int X = Convert.ToInt32(x);
            int Y = Convert.ToInt32(y);
            int Z = Convert.ToInt32(z);
            return Convert.ToString(X + Y + Z);
        }
    }
}
