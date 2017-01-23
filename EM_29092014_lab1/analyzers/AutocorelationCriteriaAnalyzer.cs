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
    public partial class AutocorelationCriteriaAnalyzer : Form, MethodAnalyzer
    {
        double n = 6;
        double[] numbers = new double[20];
        int filled = 0;
        TimelineGraph mathExpectationGraph = null;
        string name;

        public AutocorelationCriteriaAnalyzer(string name)
        {
            this.name = name;
            InitializeComponent();
            Text = ToString();
        }
        public void addNumber(double number)
        {
            if (numbers.Length != (n))
                recreateNumbers();
            numbers[filled] = number;
            filled++;
            if (filled == numbers.Length)
            {
                labelNumbersGot.Text = "Розрахунок...";
                Application.DoEvents();
                calculate1(numbers);
                Application.DoEvents();
            }
            else
            {
                labelNumbersGot.Text = "Отримано чисел: " + filled + "/" + numbers.Length;
                Application.DoEvents();
            }
        }
        private void calculate(double[] u)
        {
            int n = u.Length;
            double[] v = new double[n];
            for (int i = 0; i < n; i++)
                v[i] = u[(i + 1) % n];

            double sum0 = 0;
            for (int i = 0; i < n; i++)
                sum0 += u[i] * v[i];

            double sum1 = 0;
            for (int i = 0; i < n; i++)
                sum1 += u[i];

            double sum2 = 0;
            for (int i = 0; i < n; i++)
                sum2 += v[i];

            double sum3 = 0;
            for (int i = 0; i < n; i++)
                sum3 += Math.Pow(u[i], 2);

            double sum4 = 0;
            for (int i = 0; i < n; i++)
                sum4 += Math.Pow(v[i], 2);

            double top = n * sum0 - sum1 * sum2;
            double bottom = Math.Sqrt(n * sum3 - Math.Pow(sum1, 2) * (n * sum4 - Math.Pow(sum2, 2)));
            double k = top / bottom;
            labelResult.Text = k.ToString();
            mathExpectationGraph.addNumber(k);
            Application.DoEvents();
            recreateNumbers();
        }
        private void calculate1(double[] u)
        {
            int n = u.Length;

            double sum0 = 0;
            for (int i = 0; i <= n - 2; i++)
                sum0 += u[i] + u[i + 1];

            double sum1 = 0;
            for (int i = 0; i <= n - 1; i++)
                sum1 += u[i];

            double sum2 = 0;
            for (int i = 0; i <= n - 1; i++)
                sum2 += u[i] * u[i];

            double sum3 = 0;
            for (int i = 0; i <= n - 2; i++)
                sum3 += u[i];

            double top = n * (u[n-1]*u[0] + sum0) - sum1*sum1;
            double bottom = n * sum2 - Math.Pow(sum3, 2);
            double k = top / bottom;
            labelResult.Text = k.ToString();
            if(mathExpectationGraph != null)
                mathExpectationGraph.addNumber(k);
            Application.DoEvents();
            recreateNumbers();
        }
        private void recreateNumbers()
        {
            numbers = new double[(int)(n)];
            filled = 0;
        }
        private void MathExpectationAnalyzer_Load(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }
        public override string ToString()
        {
            return "Автокореляйійний критерій " + name;
        }

        private void MathExpectationAnalyzer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mathExpectationGraph != null)
                mathExpectationGraph.Close();
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            mathExpectationGraph = new TimelineGraph("Графік зміни " + ToString());
            mathExpectationGraph.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = (double)Int32.Parse(textBoxN.Text);
        }
    }
}
