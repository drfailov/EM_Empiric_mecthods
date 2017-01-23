using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_29092014_lab1
{
    class RandomFisherSnedekor : MyRandom
    {
        Random Hi2Random1;
        Random Hi2Random2;
        int k1 = 0;
        int k2 = 0;

        public RandomFisherSnedekor()
        {
            k1 = 3;
            k2 = 5;
            Hi2Random1 = new RandomHi2Distribution(new RandomStandartNormalDistributionBarsaliBrey(), k1);
            Hi2Random2 = new RandomHi2Distribution(new RandomStandartNormalDistributionBarsaliBrey(), k2);
        }
        public RandomFisherSnedekor(int k1, int k2)
        {
            this.k1 = k1;
            this.k2 = k2;
            Hi2Random1 = new RandomHi2Distribution(new RandomStandartNormalDistributionBarsaliBrey(), k1);
            Hi2Random2 = new RandomHi2Distribution(new RandomStandartNormalDistributionBarsaliBrey(), k2);
        }
        public override int Next()
        {
            int cnt = (int)(NextDouble() * 100);
            return cnt;
        }
        public override string ToString()
        {
            return "Розподіл Фішера Снедекора (random k1 = " + Hi2Random1.ToString() + ", random k2 = " + Hi2Random2.ToString() + ", k1=" + k1 + ", k2=" + k2 + ")";
        }
        public override double NextDouble()
        {
            double y1 = Hi2Random1.NextDouble();
            double y2 = Hi2Random2.NextDouble();
            double result = (((double)k1) * y1) / (((double)k2) * y2);
            log("x = " + result);
            return result;
        }
    }
}
