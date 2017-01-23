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
    public partial class TimelineGraph : Form, MethodAnalyzer
    {
        List<double> last = new List<double>();
        public TimelineGraph(String name)
        {
            InitializeComponent();
            Text = name;
        }
        public void addNumber(double num)
        {
            last.Add(num);
            clearOld(pictureBox1.Width);
            graph();
        }
        public void clearOld(int limit)
        {
            while (last.Count > limit)
                last.RemoveAt(0);
        }
        private void graph()
        {
            Color linesColor = Color.FromArgb(30, 30, 30);
            Color textColor = Color.FromArgb(100, 150, 100);
            Color graphColor = Color.FromArgb(100,200,250);
            double min = last[0];
            double max = last[0];
            for (int i = 0; i < last.Count; i++)
            {
                if (last[i] < min)
                    min = last[i];
                if (last[i] > max)
                    max = last[i];
            }
            double width = pictureBox1.Width;
            double height = pictureBox1.Height;
            Bitmap bitmap = new Bitmap((int)width, (int)height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            if (max != min)
            {
                max += (max - min) * 0.1d;
                min -= (max - min) * 0.1d;
                //рисовать метки
                for (double y = 10; y < height; y += 20)
                {
                    graphics.DrawLine(new Pen(linesColor), 0, (int)y, (int)width - 1, (int)y);
                    double value = ((height - y) / height) * (max - min) + min;
                    graphics.DrawString(value.ToString(), new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular), new SolidBrush(textColor), 20, (int)y + 1);
                }
                //рисовать график
                int lastPX = -1;
                int lastPY = -1;
                for (int offset = 0; offset < Math.Min(last.Count, width); offset++)
                {
                    double py = ((double)last[last.Count - 1 - offset] - (double)min) / ((double)max - (double)min) * (double)(height - 1);
                    py = height - py;
                    double px = width - 1 - offset;
                    if (lastPX == -1 || lastPY == -1)
                        bitmap.SetPixel((int)px, (int)py, graphColor);
                    else
                        graphics.DrawLine(new Pen(graphColor, 1), lastPX, lastPY, (int)px, (int)py);
                    lastPX = (int)px;
                    lastPY = (int)py;
                }
            }
            pictureBox1.Image = bitmap;
            Application.DoEvents();
        }
    }
}
