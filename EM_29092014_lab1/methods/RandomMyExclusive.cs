using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace EM_29092014_lab1
{
    class RandomMyExclusive : MyRandom
    {
        int num = 0;
        bool cont = false;
        int time = 5;
        int m = 0;

        public RandomMyExclusive()
        {
            this.time = 5;
        }
        public RandomMyExclusive(int time_ms)
        {
            this.time = time_ms;
        }
        public override int Next() //0...1000
        {
            return Next(1000);
        }
        public override int Next(int m) //0...m
        {
            this.m = m;
            Thread thread = new Thread(loto);
            cont = true;
            thread.Start();
            Thread.Sleep(time);
            int result = num;
            cont = false;
            log("result = " + result);
            return result;
        }
        public override int Next(int min, int max)
        {
            int result = Next(max - min);
            return result + min;
        }
        public override double NextDouble()
        {
            double result = Next();//0...1000000
            result /= 1000; //0...1
            return result;
        }
        public override string ToString()
        {
            return "Метод Романа Папуші (time = " + time + ") 0...999";
        }
        private void loto()
        {
            while (cont)
            {
                num += 1;
                if (num > m)
                    num = 0;
            }
        }
    }
}
