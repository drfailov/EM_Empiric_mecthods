using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EM_29092014_lab1
{

    public partial class RandomGraphic : Form
    {
        int iteratoins = 0;//лічильник ітерацій
        bool cont = false;//флажок для зупинки циклу
        List<double> numbers; //місце для збереження всіх отриманих чисел
        Random random;//обєкт рандому
        int[] repeats = new int[20];
        TimelineGraph corelationGraph = null;

        public RandomGraphic(Random r)
        {
            InitializeComponent();
            random = r;
            labelMethodName.Text = random.ToString();
        }
        public RandomGraphic()
        {
            InitializeComponent();
            random = new Random();
            labelMethodName.Text = random.ToString();
        }
        string txtlog = "";
        public void log(String txt){
            txtlog = txtlog + txt + " \n";
            Application.DoEvents();
        }

        private void buttonPlot_Click(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = null;
            if (checkBoxMusic.Checked)
            {
                soundPlayer = new SoundPlayer("sound.wav");
                soundPlayer.Play();
            }
            log("Почати анал1з методу");
            iteratoins = 0;
            int iterationsLimit = Int32.Parse(textBoxIterations.Text);
            numbers = new List<double>();
            double width = pictureBox1.Width;
            double height = pictureBox1.Height;
            int cycleTheshold = Int32.Parse(textBoxCycleThreshold.Text);
            double maxHeight = height * 0.9;
            double min = Double.Parse(textBoxMin.Text);
            double max = Double.Parse(textBoxMax.Text);
            repeats = new int[(int)width];
            int maximumCycle = 0;
            int minimumCycleDistance = -1;
            cont = true;
            while (cont == true && (iterationsLimit <= 0 ? true : iteratoins < iterationsLimit)) 
            {
                //додати лічильник ітерацій
                iteratoins++;
                double current = random.Next();//random.Next((int)min, (int)max);//0...1
                //current = transform(current, min, max);
                if (checkBoxAnalyze.Checked)
                    numbers.Add(current);
                if (current >= max || current <= min)
                    continue;
                else
                    Application.DoEvents();
                int position = (int)((current - min) * (width / (max-min)));
                repeats[position]++;
                {
                    ////шукати цикли
                    //if (checkBoxAnalyze.Checked)
                    //{
                    //    for (int i = 0; i < numbers.Count && cont; i++)
                    //    {
                    //        for (int j = i + cycleTheshold; j < numbers.Count - cycleTheshold && cont; j++)
                    //        {
                    //            int offset = 0;
                    //            int repeatCnt = 0;
                    //            while (true)
                    //            {
                    //                if (numbers[i + offset] == numbers[j + offset])
                    //                    repeatCnt++;
                    //                else
                    //                    break;
                    //                if (repeatCnt > 2 && repeatCnt > maximumCycle)
                    //                {
                    //                    //вивести проблемні числа
                    //                    String nums = " ";
                    //                    for (int k = 0; k < 10; k++)
                    //                        nums += numbers[i + k] + "(id=" + (i + k) + ")" + "  |  " + numbers[j + k] + "(id=" + (j + k) + ")   \n";
                    //                    log("Знайдено цикл довжинаю " + repeatCnt + ". Послідовність проблемних чисел: " + nums + "             ");
                    //                    labelLongestCycle.Text = "Найдовший цикл = " + maximumCycle; // runs on UI thread
                    //                    if (repeatCnt > maximumCycle)
                    //                        maximumCycle = repeatCnt;
                    //                }
                    //                if (repeatCnt >= cycleTheshold)// FOUND CYCLE
                    //                {
                    //                    //вивести відстань циклу
                    //                    int distance = j - i;
                    //                    if (minimumCycleDistance == -1 || distance < minimumCycleDistance)
                    //                    {
                    //                        minimumCycleDistance = distance;
                    //                        labelShortestCycle.Text = "Найкоротша выдстань циклу = " + minimumCycleDistance; // runs on UI thread
                    //                    };
                    //                    //завершити аналіз
                    //                    cont = false;
                    //                    break;
                    //                }
                    //                offset++;
                    //            }
                    //        }
                    //    }
                    //}
                    ////відсоток повторів
                    //if (checkBoxAnalyze.Checked)
                    //{
                    //    int cnt = 0;
                    //    for (int i = 1; i < numbers.Count; i++)
                    //    {
                    //        if (numbers[i] == numbers[i - 1])
                    //            cnt++;
                    //    }
                    //    labelRepeatsPercent.Text = "Відсоток повторів = " + (cnt * 100) / numbers.Count + "%";
                    //}

                    for (int i = 0; i < listBoxAnalyzers.Items.Count; i++)
                        ((MethodAnalyzer)listBoxAnalyzers.Items[i]).addNumber(current);

                    //Малювати графіk
                    {
                        Bitmap bitmap = new Bitmap((int)width, (int)height);
                        int maxRepeats = 0;
                        for (int i = 0; i < repeats.Length; i++)// цикл з лічильником
                            if (repeats[i] > maxRepeats)
                                maxRepeats = repeats[i];
                        double heightPerRepeat = (maxHeight / maxRepeats);
                        for (int i = 0; i < repeats.Length; i++)// цикл з лічильником
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
                                //if (checkBoxAnalyze.Checked)
                                {
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
                        }
                        pictureBox1.Image = bitmap;
                        labelIterations.Text = "Ітерацій: " + iteratoins;
                        Application.DoEvents();
                    }
                }
            }
            if(soundPlayer != null)
                soundPlayer.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cont = false;
        }
        double transform(double src, double min, double max)
        {
            double d = max - min;
            double result = src * d;//0...d
            result += min; //min...max
            return result;
        }
        private void textBoxLog_DoubleClick(object sender, EventArgs e)//clear log
        {
        }
        // ПОШУК ЦИКЛІВ
        List<double> tmpNumbersCopy = null;
        int tmpCycleTheshold=0;
        bool numbersReady = true;
        private void findCycles(List<double> numbers, int cycleTheshold)
        {
            while (!numbersReady && cont) { Thread.Sleep(10); }
            numbersReady = false;
            tmpCycleTheshold = cycleTheshold;
            tmpNumbersCopy = new List<double>();
            numbers.ForEach((item) =>  {  tmpNumbersCopy.Add(item); });
            new Thread(findCycles).Start();
        }
        private void findCycles()
        {
            List<double> numbersCopy = tmpNumbersCopy;
            int cycleTheshold = tmpCycleTheshold;
            numbersReady = true;

            int maximumCycle = 0;
            int minimumCycleDistance = -1;
            for (int i = 0; i < numbers.Count && cont; i++)
            {
                for (int j = i + cycleTheshold; j < numbers.Count - cycleTheshold; j++)
                {
                    int offset = 0;
                    int repeatCnt = 0;
                    while (true)
                    {
                        if (numbers[i + offset] == numbers[j + offset])
                            repeatCnt++;
                        else
                            break;
                        if (repeatCnt >= cycleTheshold)// FOUND CYCLE
                        {
                            //вивести проблемні числа
                            String nums = " ";
                            for (int k = i; i < i + 10; k++)
                                nums += numbers[i] + "   ";
                            this.Invoke((MethodInvoker)delegate
                            {
                                log("Послідовність проблемних чисел: " + nums);
                            });
                            //вивести відстань циклу
                            int distance = j - i;
                            if (minimumCycleDistance == -1 || distance < minimumCycleDistance)
                            {
                                minimumCycleDistance = distance;
                                this.Invoke((MethodInvoker)delegate
                                {
                                    labelShortestCycle.Text = "Найкоротша выдстань циклу = " + minimumCycleDistance; // runs on UI thread
                                });
                            };
                            //завершити аналіз
                            cont = false;
                        }
                        offset++;
                    }
                    if (repeatCnt > maximumCycle)
                        maximumCycle = repeatCnt;
                }
            } 
            this.Invoke((MethodInvoker)delegate
            {
                labelLongestCycle.Text = "Найдовший цикл = " + maximumCycle; // runs on UI thread
            });
        }
        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {

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
        private void buttonCorelation_Click(object sender, EventArgs e)
        {
        }

        private void buttonDeleteAnalyzer_Click(object sender, EventArgs e)
        {
            ((Form)listBoxAnalyzers.SelectedItem).Close();
            listBoxAnalyzers.Items.Remove(listBoxAnalyzers.SelectedItem);
        }

        private void buttonAddAnalyzerContinuousGaussRandomProcess_Click(object sender, EventArgs e)
        {
            ContinuousGaussProcessAnalyzer analyzer = new ContinuousGaussProcessAnalyzer();
            analyzer.Show();
            listBoxAnalyzers.Items.Add(analyzer);
        }

        private void buttonAddMathExpectationAnalyzer_Click(object sender, EventArgs e)
        {
            MathExpectationAnalyzer analyzer = new MathExpectationAnalyzer("випадкове число");
            analyzer.Show();
            listBoxAnalyzers.Items.Add(analyzer);
        }

        private void RandomGraphic_FormClosing(object sender, FormClosingEventArgs e)
        {
            cont = false;
            foreach (Form form in listBoxAnalyzers.Items)
            {
                form.Close();
            }
        }

        private void buttonAddDispersionAnalyzer_Click(object sender, EventArgs e)
        {
            DispersionAnalyzer analyzer = new DispersionAnalyzer("випадкове число");
            analyzer.Show();
            listBoxAnalyzers.Items.Add(analyzer);
        }

    }
}
