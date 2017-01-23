using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_29092014_lab1
{
    class RandomLinearCongurent : MyRandom
    {
        int a;
        int c;
        int m;
        int xi;

        public RandomLinearCongurent(int a, int c, int m, int seed) {
            this.a = a;
            this.c = c;
            this.m = m;
            this.xi = seed;
        }
        public RandomLinearCongurent()
        {
            a = System.DateTime.Now.Millisecond % 10;
            c = System.DateTime.Now.Millisecond % 30;
            m = System.DateTime.Now.Millisecond % 100;
            xi = System.DateTime.Now.Millisecond % m;
        }
        public override int Next()
        {
            xi = (a * xi + c) % m;
            log("xi = " + xi);
            return xi;
        }
        public override string ToString()
        {
            return "Лінійний конгурентний метод (a = "+a+"; c = "+c+"; m = "+m+"; seed = "+xi+" ) 0..." + m;
        }
    }
}
