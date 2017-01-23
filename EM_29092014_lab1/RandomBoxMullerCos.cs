using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_29092014_lab1
{
    class RandomBoxMullerCos : MyRandom
    {
        double n = 0;
        public RandomBoxMullerCos() : base()
        {
            n = 12;
        }
        public RandomBoxMullerCos(int n)
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
            double alpha1 = base.NextDouble();
            double alpha2 = base.NextDouble();
            double ksi = Math.Sqrt(-2 * Math.Log10(alpha1)) * Math.Cos(2 * Math.PI * alpha2);
            if(n > 0)
                ksi = (ksi - (n / 2)) / (Math.Sqrt(n / 12));
            return ksi;
        }
        public override string ToString()
        {
            return "Метод Бокса Мюллера (Формула для cos) ( n = " + n + ") -500...500";
        }
    }
}
