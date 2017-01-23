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
    public partial class EventAppearAnalyzer : Form, MethodAnalyzer
    {
        double n = 6;
        double nt = 6;
        double lambda = 5;
        double[] numbers = new double[20];
        int filled = 0;
        string name;

        public EventAppearAnalyzer(string name)
        {
            this.name = name;
            InitializeComponent();
            Text = ToString();
        }
        public void addNumber(double number)
        {
            if (numbers.Length != (n + nt))
                recreateNumbers();
            numbers[filled] = number;
            filled++;
            if (filled == numbers.Length)
            {
                labelNumbersGot.Text = "Розрахунок...";
                Application.DoEvents();
                calculate(numbers);
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
            double[] ts = new double[(int)nt];//5
            for (int i = 0; i < nt; i++)
                ts[i] = u[i];
            double[] t = new double[(int)n];//100
            for (int i = (int)nt; i < n + nt; i++)
                t[i-(int)nt] = u[i];

            Array.Sort(ts);
            ts[0] = 0;
            double[] result = new double[(int)nt - 1];
            for (int i = 0; i < result.Length; i++)
                result[i] = 0;
            String fki = "";
            for (int i = 0; i < t.Length; i++)
            {
                double f = 1;
                if (radioButton1.Checked)
                    f = lambda * Math.Pow(Math.E, -lambda * t[i]) * Math.Pow(lambda * t[i], n - 1) / factorial(n - 1);
                if (radioButton2.Checked)
                    f = Math.Pow(Math.E, -lambda * t[i]) * Math.Pow(lambda * t[i], n) / factorial(n - 1);
                fki += f + "  ";
                for (int j = 0; j < ts.Length - 1; j++)
                {
                    if (f > ts[j] && f <= ts[j + 1])
                        result[j]++;
                }
            }
            label6.Text = fki;
            label4.Text = arrayToString(ts);
            label5.Text = arrayToString(result);
            makeGraphic(result);
            Application.DoEvents();
            recreateNumbers();
        }
        public double factorial(double num)
        {
            double fact = 1;
            for (double i = 1; i <= num; i++)
                fact *= i;
            return fact;
        }

        private String arrayToString(double[] array){
            String result = "";
            for (int i = 0; i < array.Length; i++)
                result += array[i] + "\n";
            return result;
        }
        private void makeGraphic(double[] realResults)
        {
            try
            {
                getMax(realResults);
                double width = pictureBox1.Width;
                double height = pictureBox1.Height;
                Bitmap bitmap = new Bitmap((int)width, (int)height);
                addCurve(realResults, Color.Yellow, bitmap, width, height);
                pictureBox1.Image = bitmap;
                Application.DoEvents();
            }
            catch (Exception e) { };
        }
        private void addCurve(double[] mas, Color color, Bitmap bitmap, double width, double height)
        {
                double max = getMax(mas);
                max += 1d;
                double lastCX = -1;
                double lastCY = -1;
                Graphics graphics = Graphics.FromImage(bitmap);
                for (double i = 0; i < mas.Length; i++)
                {
                    try
                    {
                        double cx = (i / (double)mas.Length) * (width - 1);
                        double cy = height - 1 - ((mas[(int)i] / max) * (height - 5));
                        if (lastCX >= 0)
                            graphics.DrawLine(new Pen(color, 1), (int)lastCX, (int)lastCY, (int)cx, (int)cy);
                        else
                            bitmap.SetPixel((int)cx, (int)cy, color);
                        lastCX = cx;
                        lastCY = cy;
                    }
                    catch (Exception exc) { }
                }
        }
        private double getMax(double[] mas)
        {
            double max = 0;
            for (int i = 0; i < mas.Length; i++)
                if (max < mas[i])
                    max = mas[i];
            return max;
        }
        private void recreateNumbers()
        {
            numbers = new double[(int)(n + nt)];
            filled = 0;
        }
        private void MathExpectationAnalyzer_Load(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }
        public override string ToString()
        {
            return "Час появи заданої події " + name;
        }
        private void button1_Click(object sender, EventArgs e)//apply
        {
            n = (double)Int32.Parse(textBoxN.Text);
            nt = (double)Int32.Parse(textBoxNT.Text);
            lambda = (double)Int32.Parse(textBoxLambda.Text);
        }
    }
}
