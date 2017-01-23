using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_29092014_lab1
{
    class RandomLevisPane : MyRandom
    {
        int m;
        int a;
        int b;
        Queue<int> x;

        public RandomLevisPane()
        {
            m = 1000;
            a = 38;
            b = 89;
            initNums();
        }
        public RandomLevisPane(int m, int a, int b)
        {
            this.m = m;
            this.a = a;
            this.b = b;
            initNums();
        }
        private void initNums()
        {
            int max = Math.Max(a, b) + 3;
            x = new Queue<int>(max);
            Random random = new Random();
            for (int i = 0; i < max; i++)
                x.Enqueue(random.Next(m));
        }
        public override int Next()
        {
            int result = (x.ElementAt(x.Count - a) ^ x.ElementAt(x.Count - b)) % m;
            log("x = " + result);
            x.Peek();
            x.Enqueue(result);
            return result;
        }
        public override string ToString()
        {
            return "Метод Левіса Пейна (m = "+m+"; a = "+a+"; b = "+b+") 0..." + m;
        }
        public override double NextDouble()
        {
            double mod = m;
            double result = Next();
            result /= mod;
            return result;
        }
    }
}
