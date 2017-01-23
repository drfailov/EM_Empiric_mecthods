using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_29092014_lab1
{
    class RandomExponentialDistribution : MyRandom
    {
        Random r;
        double lambda;

        public RandomExponentialDistribution()
        {
            lambda = 1.5;
            r = new MyRandom();
        }
        public RandomExponentialDistribution(double lambda, Random r)
        {
            this.r = r;
            this.lambda = lambda;
        }
        public override int Next()
        {
            return (int)(NextDouble() * 100d);
        }
        public override string ToString()
        {
            return "Показниковий розподіл (lambda = " + lambda + "; random = " + r.ToString() + ")";
        }
        public override double NextDouble()
        {
            double u = r.NextDouble();
            double x = -lambda * Math.Log(u);
            log("x = " + x);
            return x;
        }
    }
}
