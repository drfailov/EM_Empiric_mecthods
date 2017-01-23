using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_29092014_lab1
{
    class RandomLevin : MyRandom
    {
        double t;
        int xi;
        int m;

        public RandomLevin()
        {
            this.m = 199;
            this.xi = System.DateTime.Now.Millisecond % m;
            t = (int)(Math.Log(m, 2) + 1);
        }
        public RandomLevin(int m, int seed)
        {
            this.m = m;
            this.xi = seed;
            t = (Math.Log(m, 2) + 1);
        }
        public override int Next()
        {
            log("xi = " + xi);
            int yi = (int)((xi * t) % 2);
            xi = (xi * xi) % m;
            log("yi = " + yi);
            return yi;
        }
        public override string ToString()
        {
            return "Метод Леоніда Левіна (t = " + t + ";m = " + m + "; seed = " + xi + ") 0...1";
        }
    }
}
