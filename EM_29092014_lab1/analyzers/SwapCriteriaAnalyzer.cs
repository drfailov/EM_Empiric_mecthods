using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EM_29092014_lab1
{
    public partial class SwapCriteriaAnalyzer : Form, MethodAnalyzer
    {
        double[] numbers = new double[20];
        int filled = 0;
        TimelineGraph TimelineGraph = null;
        Hi2Analyzer hi2analyzer;
        string name;
        double t = 2;
        double n = 6;

        public SwapCriteriaAnalyzer(string name)
        {
            this.name = name;
            InitializeComponent();
            Text = ToString();
            hi2analyzer = new Hi2Analyzer();
            hi2analyzer.Show();
        }
        public void addNumber(double number)
        {
            if (numbers.Length != (t * n))
                recreateNumbers();
            numbers[filled] = number;
            filled++;
            if (filled == numbers.Length)
            {
                labelNumbersGot.Text = "Розрахунок...";
                Application.DoEvents();
                calculate(numbers, t, n);
                Application.DoEvents();
            }
            else
            {
                labelNumbersGot.Text = "Отримано чисел: " + filled + "/" + numbers.Length;
                Application.DoEvents();
            }
        }
        private void calculate(double[] u, double t, double n)
        {
            //розбити послідовність на n груп
            double[][] groups = new double[(int)n][];
            for (int i = 0; i < n; i++)
            {
                double[] group = new double[(int)t];
                for (int j = 0; j < t; j++)
                    group[j] = u[i * (int)t + j];
                groups[i] = group;
            }
            //створити масив для кожного варіанту перестановки
            int tfact = (int)factorial(t);
            double[] swapsPractical = new double[tfact];
            for(int i=0; i<n; i++)
            {
                double[] group = groups[i];
                int numberOfSwapping = findSwapNumber(group, (int)t);
                swapsPractical[numberOfSwapping]+= 1d/n;
            }
            //створити теоретичний масив
            double[] swapsTheoretical = getTheoretical((int)t);
            double result = hi2analyzer.calculate(swapsPractical, swapsTheoretical);
            labelResult.Text = result.ToString();
            if (TimelineGraph != null)
                TimelineGraph.addNumber(result);
            recreateNumbers();
        }
        public double factorial(double num)
        {
            double fact = 1;
            for (double i = 1; i <= num; i++)
                fact *= i;
            return fact;
        }
        public double[] getTheoretical(int t)
        {
            int fact = (int)factorial(t);
            double[] result = new double[fact];
            for (int i = 0; i < fact; i++)
                result[i] = 1d / fact;
            return result;
        }
        private int findSwapNumber(double[] U, int t)
        {
            int r = t-1;
            int f = 0;
            while (r > 0)
            {
                //пошук максимума
                double Us = U[0];
                int s = 0;
                for (int i = 0; i <= r; i++)
                    if (U[i] > Us)
                    {
                        Us = U[i];
                        s = i;
                    }
                // f
                f = (r+1) * f + s;// - 1;
                //swap 
                double tmp = U[r];
                U[r] = U[s];
                U[s] = tmp;
                //
                r--;
            }
            return f;
        }
        private void recreateNumbers()
        {
            numbers = new double[(int)(t * n)];
            filled = 0;
        }
        private void MathExpectationAnalyzer_Load(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }
        public override string ToString()
        {
            return "Критерій перестановок " + name;
        }

        private void MathExpectationAnalyzer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hi2analyzer != null)
                hi2analyzer.Close();
            if (TimelineGraph != null)
                TimelineGraph.Close();
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            TimelineGraph = new TimelineGraph("Графік зміни " + ToString());
            TimelineGraph.Show();
        }

        private void button1_Click(object sender, EventArgs e)//apply
        {
            t = (double)Int32.Parse(textBoxT.Text);
            n = (double)Int32.Parse(textBoxN.Text);
        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelNumbersGot_Click(object sender, EventArgs e)
        {

        }
    }
}
