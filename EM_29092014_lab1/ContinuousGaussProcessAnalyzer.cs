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
    public partial class ContinuousGaussProcessAnalyzer : Form, MethodAnalyzer
    {
        List<double> last = new List<double>();
        TimelineGraph ksi1Graph;
        TimelineGraph ksi2Graph;
        MathExpectationAnalyzer ksi1MEAnalyzer;
        MathExpectationAnalyzer ksi2MEAnalyzer;
        DispersionAnalyzer ksi1DIAnalyzer;
        DispersionAnalyzer ksi2DIAnalyzer;
        double M = 9;
        Random random = new Random();

        public ContinuousGaussProcessAnalyzer()
        {
            InitializeComponent();

            ksi1Graph = new TimelineGraph("Графік величини ksi1");
            ksi1Graph.Show();

            ksi2Graph = new TimelineGraph("Графік величини ksi2");
            ksi2Graph.Show();

            ksi1MEAnalyzer = new MathExpectationAnalyzer("ksi1");
            ksi1MEAnalyzer.Show();

            ksi2MEAnalyzer = new MathExpectationAnalyzer("ksi2");
            ksi2MEAnalyzer.Show();

            ksi1DIAnalyzer = new DispersionAnalyzer("ksi1");
            ksi1DIAnalyzer.Show();

            ksi2DIAnalyzer = new DispersionAnalyzer("ksi2");
            ksi2DIAnalyzer.Show();
            
        }
        public void addNumber(double number)
        {
            last.Add(number);
            labelNumber.Text = number.ToString();
            int limit = (int)M * 2;
            if (last.Count > limit)
            {
                labelFilling.Text = "Розрахунок ...";

                for (double t = 0; t < 100; t++)
                {
                    double ksi1 = ksi1Calculate(t);
                    ksi1Graph.addNumber(ksi1);
                    ksi1MEAnalyzer.addNumber(ksi1);
                    ksi1DIAnalyzer.addNumber(ksi1);
                    Application.DoEvents();
                }
                for (double t = 0; t < 100; t++)
                {
                    double ksi2 = ksi1Calculate(t);
                    ksi2Graph.addNumber(ksi2);
                    ksi2MEAnalyzer.addNumber(ksi2);
                    ksi2DIAnalyzer.addNumber(ksi2);
                    Application.DoEvents();
                }

                last.Clear();
            }
            else
            {
                labelFilling.Text = last.Count + " / " + limit;
            }
        }
        public double ksi1Calculate(double t)
        {
            double ksi1 = 0;
            for (double i = 0; i < M; i++)
            {
                ksi1 += Math.Cos(lambdai(i) * t) * xi(i) + Math.Cos(lambdai(i) * t) * yi(i);
            }
            return ksi1;
        }
        public double ksi2Calculate(double t)
        {
            double ksi2 = 0;
            for (double i = 0; i < M; i++)
            {
                ksi2 += Math.Cos(lambdai(i) * t) * xi(i) + Math.Cos(lambdai2(i) * t) * yi(i);
            }
            return ksi2;
        }
        public double xi(double i)
        {
            return last[(int)i] * (1 / Math.Pow(1 + Math.PI * i, 2));
        }
        public double yi(double i)
        {
            return last[(int)i + (int)M] * (1 / Math.Pow(1 + Math.PI * i, 2));
        }
        public double lambdai(double i)
        {
            return Math.PI * i;
        }
        public double lambdai2(double i)
        {
            return Math.PI * (i + random.NextDouble());
        }
        public void clearOld(int limit)
        {
            while (last.Count > limit)
                last.RemoveAt(0);
        }
        private void ContinuousGaussProcessAnalyzer_Load(object sender, EventArgs e)
        {

        }
        public override string ToString()
        {
            return "Неперервний гаусівський випадковий процес";
        }

        private void ContinuousGaussProcessAnalyzer_FormClosing(object sender, FormClosingEventArgs e)
        {
            ksi1Graph.Close();
            ksi2Graph.Close();
            ksi1MEAnalyzer.Close();
            ksi2MEAnalyzer.Close();
        }
    }
}
