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
    public partial class DensityAnalyser : Form, MethodAnalyzer
    {
        int[] repeats = new int[20];
        string name;
        public DensityAnalyser(string name)
        {
            this.name = name;
            InitializeComponent();
            Text = ToString();
        }
        public void addNumber(double number)
        {
            labelNumber.Text = number.ToString();
            double width = pictureBox1.Width;
            if (repeats.Length != width)
                repeats = new int[(int)width];
            double height = pictureBox1.Height;
            double maxHeight = height * 0.9;
            double min = Double.Parse(textBoxMin.Text);
            double max = Double.Parse(textBoxMax.Text);
            Bitmap bitmap = new Bitmap((int)width, (int)height);
            int maxRepeats = 1;
            for (int i = 0; i < repeats.Length; i++)
                if (repeats[i] > maxRepeats)
                    maxRepeats = repeats[i];
            double heightPerRepeat = (maxHeight / maxRepeats);
            if (number >= max || number <= min)
                return;
            else
                Application.DoEvents();
            int position = (int)((number - min) * (width / (max - min)));
            repeats[position]++;
            for (int i = 0; i < repeats.Length; i++)
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    double cur = min + i * ((max - min) / width);
                    //малювати цифри на графіку
                    if (i % 40 == 0)
                    {
                        g.DrawLine(new Pen(Color.FromArgb(30, 30, 30)), new Point(i, (int)height), new Point(i, 0));
                        cur = Math.Round(cur, 2);
                        g.DrawString(cur.ToString(), new Font("Tahoma", 8), Brushes.Gray, i + 5, 20);
                    }
                    Point top_ro = new Point(i, (int)(height - repeats[i] * heightPerRepeat));
                    Point bottom = new Point(i, (int)height);
                    g.DrawLine(new Pen(Color.FromArgb(80, 0, 255, 0)), bottom, top_ro);
                    g.DrawEllipse(new Pen(Color.FromArgb(255, 0, 255, 0)), top_ro.X, top_ro.Y, 1, 1);
                    //малювати функцію розподілу
                    double all = 0;
                    double less = 0;
                    for (int j = 0; j < repeats.Length; j++)
                    {
                        all += repeats[j];
                        if (j < i)
                            less += repeats[j];
                    }
                    Point top_f = new Point(i, (int)(height - (height * less / all)));
                    g.DrawLine(new Pen(Color.FromArgb(40, 255, 0, 0)), bottom, top_f);
                    g.DrawEllipse(new Pen(Color.FromArgb(150, 255, 0, 0)), top_f.X, top_f.Y, 1, 1);
                }
            }
            pictureBox1.Image = bitmap;
            Application.DoEvents();
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            double minD = Double.Parse(textBoxMin.Text);
            double maxD = Double.Parse(textBoxMax.Text);
            double maxRepeats = 0;
            for (int i = 0; i < repeats.Length; i++)// цикл з лічильником
                if (repeats[i] > maxRepeats)
                    maxRepeats = repeats[i];

            double curD = minD + e.X * ((maxD - minD) / pictureBox1.Width);
            double curN = ((pictureBox1.Height - e.Y) * (maxRepeats / (double)pictureBox1.Height));
            labelPosition.Text = "Курсор: " + Math.Round(curD, 2) + " x " + Math.Round(curN, 2);
        }
        public override string ToString()
        {
            return "Густина розподілу " + name;
        }

        private void button1_Click(object sender, EventArgs e)//clear
        {
            repeats = new int[pictureBox1.Width];
        }
    }
}
