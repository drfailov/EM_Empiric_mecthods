using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_29092014_lab1
{
    class RandomKovey : MyRandom
    {
        int last;
        int e;

        public RandomKovey()
        {
            last = DateTime.Now.Millisecond;
        }
        public RandomKovey(int e, int seed)
        {
            this.last = seed;
            this.e = e;
        }
        public override int Next()
        {
            int result;
            double mod = Math.Pow(2, e);
            log("mod = " + mod);
            result = last * (last + 1);
            log("number = " + result);
            result = result % (int)mod;
            log("result = " + result);
            last = result;
            return result;
        }
        public override int Next(int maxValue)
        {
            int result = Next() % maxValue;
            log("result = " + result);
            return result;
        }
        public override int Next(int minValue, int maxValue)
        {
            int result = Next(maxValue - minValue) + minValue;
            log("result = " + result);
            return result;
        }
        public override double NextDouble()
        {
            double mod = Math.Pow(2, e);
            double result = Next();
            result /= mod;
            return result;
        }
        public override string ToString()
        {
            return "Метод Ковея (" + "seed = " + last + ", e = " + e + ") 0..." + Math.Pow(2, e);
        }
    }
}
