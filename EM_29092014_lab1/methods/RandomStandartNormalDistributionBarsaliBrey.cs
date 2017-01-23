using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_29092014_lab1
{
    class RandomStandartNormalDistributionBarsaliBrey : MyRandom
    {
        Random r;
        double w2;
        int step = 1;

        public RandomStandartNormalDistributionBarsaliBrey()
        {
            r = new MyRandom();
        }
        public RandomStandartNormalDistributionBarsaliBrey(Random r)
        {
            this.r = r;
        }
        public override int Next()
        {
            int cnt = (int)(NextDouble() * 100);
            return cnt;
        }
        public override string ToString()
        {
            return "Стандартний нормальний розподіл Марсалії Брея (random = " + r.ToString() + ")";
        }
        public override double NextDouble()
        {
            if (step == 1)
            {
                double v1 = 1;
                double v2 = 1;
                double s = 1;
                while (s >= 1)
                {
                    double u1 = r.NextDouble();
                    double u2 = r.NextDouble();
                    v1 = 2 * u1 - 1;
                    v2 = 2 * u2 - 1;
                    s = v1 * v1 + v2 * v2;
                }
                double w1 = v1 * Math.Sqrt((-2 * Math.Log(s)) / (s));
                w2 = v2 * Math.Sqrt((-2 * Math.Log(s)) / (s));
                step = 2;
                log("x = " + w1);
                return w1;
            }
            else
            {
                step = 1;
                log("x = " + w2);
                return w2;
            }
        }
    }
}
