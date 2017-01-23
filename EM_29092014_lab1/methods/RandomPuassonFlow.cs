using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_29092014_lab1
{
    class RandomPuassonFlow : MyRandom
    {
        double lambda;
        Random random = new Random();
        int variation = 0; //0.1.2.3...

        public RandomPuassonFlow(double lambda, int variation = 0) {
            this.lambda = lambda;
            this.variation = variation;
        }
        public RandomPuassonFlow()
        {
            lambda = (int)(System.DateTime.Now.Millisecond % 10);
        }
        public override int Next()
        {
            switch (variation)
            {
                case 0:
                    {
                        double r = random.NextDouble();
                        double t = (-1d / lambda) * Math.Log10(1d - r);
                        t *= 1000;
                        log("result = " + t);
                        return (int)(t);
                    }
                case 1:
                    {
                        double r = 1;
                        for (int i = 0; i < 100; i++)
                            r *= random.NextDouble();
                        double t = (-1d / lambda) * Math.Log10(r);
                        log("result = " + t);
                        return (int)(t);
                    }
                case 2:
                    {
                        double r = random.NextDouble();
                        double t = (-1d / lambda) * Math.Log10(1d - r);
                        t *= 1000;
                        log("result = " + t);
                        return (int)(t);
                    }
                case 3:
                    {
                        double sum = 0;
                        for (int i = 0; i < 100; i++) { 
                            double r = random.NextDouble();
                            double t = (-1d / lambda) * Math.Log10(1d - r);
                            sum += t;
                        }
                        log("result = " + sum);
                        return (int)(sum);
                    }
                default:
                    return 0;
            }
        }
        public override string ToString()
        {
            return "Метод потоку пуасона (lambda = "+lambda+"; формула "+variation+") 1...1500";
        }
        public override double NextDouble()
        {
            double mod = 1500;
            double result = Next();
            result /= mod;
            return result;
        }
    }
}
