using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM_29092014_lab1
{
    class RandomBoxMullerSinBinary : RandomBoxMullerSin
    {
        int last = 0;
        public RandomBoxMullerSinBinary() : base(1)
        {
        }
        public override int Next()//0, 1
        {
            int next = (int)(NextDouble() * 100);//0...100
            int d = next - last;
            int result = d > 0 ? 1 : 0;
            last = next;
            log("result = " + result);
            return result;
        }
        public override string ToString()
        {
            return "Двійковий " + base.ToString() + " 0...1";
        }
    }
}
