using System;
using АщевTaylorExp;

namespace АщевTouchCalcExp
{
    class TouchCalcExp : TaylorExp
    {
        double S = 0;
        double k;
        public TouchCalcExp(double x, double w)
        {
            k = Taylor(x, 1);
            int i = 0;
            while (Math.Abs(k) > w)
            {
                S += k;
                i += 1;
                k = Taylor(x, i);
            }
        }
        public double MyExp()
        {
            return S;
        }
    }
}
