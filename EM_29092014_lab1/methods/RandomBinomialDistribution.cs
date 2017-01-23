using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_29092014_lab1
{
    class RandomBinomialDistribution : MyRandom
    {
        Random r;
        double n;
        double p;

        public RandomBinomialDistribution()
        {
            n = 100;
            p = 0.5;
            r = new Random();
        }
        public RandomBinomialDistribution(double n, double p, Random r)
        {
            this.r = r;
            this.p = p;
            this.n = n;
        }
        public override int Next()
        {
            int cnt = 0;
            for (int i = 0; i < n; i++)
                if (r.NextDouble() < p)
                    cnt++;
            log("x = " + cnt);
            return cnt;
        }
        public override string ToString()
        {
            return "Біноміальний розподіл (n = " + n + "; p = " + p + "; random = " + r.ToString() + ")";
        }
        public override double NextDouble()
        {
            return (double)Next() / (double)100;
        }
    }
}
