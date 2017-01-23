using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_29092014_lab1
{
    class RandomHi2Distribution : MyRandom
    {
        Random standardNormalRandom;
        int n = 0;

        public RandomHi2Distribution()
        {
            standardNormalRandom = new RandomStandartNormalDistributionBarsaliBrey();
            n = 5;
        }
        public RandomHi2Distribution(Random standardNormalRandom, int n)
        {
            this.standardNormalRandom = standardNormalRandom;
            this.n = n;
        }
        public override int Next()
        {
            int cnt = (int)(NextDouble() * 100);
            return cnt;
        }
        public override string ToString()
        {
            return "Хі-квадрат розподіл (random = " + standardNormalRandom.ToString() + ", n="+n+")";
        }
        public override double NextDouble()
        {
            double result = 0;
            for (int i = 0; i < n; i++)
                result += standardNormalRandom.NextDouble();
            log("x = " + result);
            return result;
        }
    }
}
