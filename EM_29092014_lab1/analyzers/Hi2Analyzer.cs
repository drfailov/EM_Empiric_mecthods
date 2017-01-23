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
    public partial class Hi2Analyzer : Form
    {
        double max = 0;
        public Hi2Analyzer()
        {
            InitializeComponent();
        }
        public double calculate(double[] realResults, double[] theoreticalResults)
        {
            makeGraphic(realResults, theoreticalResults);
            double sum = 0;
            for (int i = 0; i < Math.Min(realResults.Length, theoreticalResults.Length); i++)
                sum += Math.Pow(realResults[i] - theoreticalResults[i], 2) / theoreticalResults[i];
            labelResult.Text = sum.ToString();
            Application.DoEvents();
            return sum;
        }
        private void makeGraphic(double[] realResults, double[] theoreticalResults)
        {
            getMax(realResults);
            getMax(theoreticalResults);
            double width = pictureBoxGraphic.Width;
            double height = pictureBoxGraphic.Height;
            Bitmap bitmap = new Bitmap((int)width, (int)height);
            addCurve(realResults, Color.Red, bitmap, width, height);
            addCurve(theoreticalResults, Color.Green, bitmap, width, height);
            pictureBoxGraphic.Image = bitmap;
            Application.DoEvents();
        }
        private void addCurve(double[] mas, Color color, Bitmap bitmap, double width, double height)
        {
            try
            {
                double max = getMax(mas);
                double lastCX = -1;
                double lastCY = -1;
                Graphics graphics = Graphics.FromImage(bitmap);
                for (double i = 0; i < mas.Length; i++)
                {
                    double cx = (i / (double)mas.Length) * (width-1);
                    double cy = height - 1 - ((mas[(int)i] / max) * (height-5));
                    if (lastCX >= 0)
                        graphics.DrawLine(new Pen(color, 1), (int)lastCX, (int)lastCY, (int)cx, (int)cy);
                    else
                        bitmap.SetPixel((int)cx, (int)cy, color);
                    lastCX = cx;
                    lastCY = cy;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.StackTrace);
            }
        }
        private double getMax(double[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
                if (max < mas[i])
                    max = mas[i];
            return max;
        }
    }
}
