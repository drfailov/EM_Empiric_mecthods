using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_29092014_lab1
{
    class RandomStandartNormalDistributionCentralEdgeTheorema : MyRandom
    {
        int n = 0;
        public RandomStandartNormalDistributionCentralEdgeTheorema() : base()
        {
            n = 12;
        }
        public RandomStandartNormalDistributionCentralEdgeTheorema(int n)
            : base()
        {
            this.n = n;
        }
        public override int Next()//0...100
        {
            int result = (int)(NextDouble() * 100);
            log("result = " + result);
            return result;
        }
        public override int Next(int maxValue)
        {
            return (int)(NextDouble() * maxValue);
        }
        public override int Next(int minValue, int maxValue)
        {
            int result = Next(maxValue - minValue) + minValue;
            return result;
        }
        public override double NextDouble()//0...1
        {
            double[] mas = new double[n];
            for (int i = 0; i < n; i++)
                mas[i] = base.NextDouble() - 0.5;
            double sum = 0;
            for (int i = 0; i < n; i++)
                sum += mas[i];
            sum *= Math.Sqrt(12 / (double)n);
            return sum;
        }
        public override string ToString()
        {
            return "Стандартний нормальний розподіл за центральною граничною теоремою ( n = "+n+")";
        }
    }
}
