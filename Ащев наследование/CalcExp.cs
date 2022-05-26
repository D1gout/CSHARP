using System;
using АщевTaylorExp;

namespace АщевCalcExp
{
    class CalcExp : TaylorExp
    {
        double result;
        
        public CalcExp(double x, int n)
        {
            for (int i = 1; i <= n; i++)
                result += Taylor(x, i);
        }
        public double MyExp()
        {
            return result;
        }
    }
}
