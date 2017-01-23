using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_29092014_lab1
{
    class RandomConcatenateSequences : MyRandom
    {
        Random r;
        int m;
        int x;

        public RandomConcatenateSequences()
        {
            m = 1000;
            x = System.DateTime.Now.Millisecond % m;
            r = new MyRandom();
        }
        public RandomConcatenateSequences(int m, int seed, Random r)
        {
            this.m = m;
            this.x = seed;
            this.r = r;
        }
        public override int Next()
        {
            int y = r.Next();
            x = (x + y) % m;
            log("x = " + x);
            return x;
        }
        public override string ToString()
        {
            return "Метод об'єднання послідосностей (m = " + m + "; seed = " + x + "; random = " + r.ToString() +") 0..." + m;
        }
        public override double NextDouble()
        {
            return (double)Next() / (double)m;
        }
    }
}
