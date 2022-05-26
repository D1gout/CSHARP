using System;

namespace АщевTaylorExp
{
    abstract class TaylorExp
    {
        public double Taylor(double x, int n) => Math.Pow(x, n) / n;
    }
}