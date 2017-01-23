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

    public partial class MethodAnalyzeWindow : Form
    {
        int iteratoins = 0;//лічильник ітерацій
        bool cont = false;//флажок для зупинки циклу
        Random random;//обєкт рандому
        SoundPlayer soundPlayer = null;

        public MethodAnalyzeWindow(Random r)
        {
            InitializeComponent();
            buttonAddDensityAnalyser.Focus();
            random = r;
            labelMethodName.Text = random.ToString();
        }
        public MethodAnalyzeWindow()
        {
            InitializeComponent();
            buttonAddDensityAnalyser.Focus();
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
            iteratoins = 0;
            int iterationsLimit = Int32.Parse(textBoxIterations.Text);
            cont = true;
            while (cont == true && (iterationsLimit <= 0 ? true : iteratoins < iterationsLimit)) 
            {
                generate();
            }
            if(soundPlayer != null)
                soundPlayer.Stop();
        }
        private void generate()
        {
            iteratoins++;
            double current;
            if (checkBoxdouble.Checked)
                current = random.NextDouble();
            else
                current = random.Next();
            if (checkBoxInterval.Checked)
            {
                int min = Int32.Parse(textBoxMin.Text);
                int max = Int32.Parse(textBoxMax.Text);
                int d = max - min;
                current = Math.Abs(current % d) + min;
            }
            labelNumber.Text = current.ToString();
            for (int i = 0; i < listBoxAnalyzers.Items.Count; i++)
            {
                ((MethodAnalyzer)listBoxAnalyzers.Items[i]).addNumber(current);
            }
            labelIterations.Text = "Ітерацій: " + iteratoins;
            Application.DoEvents();
        }
        private void buttonPlot_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                soundPlayer = new SoundPlayer("sound.wav");
                soundPlayer.Play();
                buttonPlot_Click(sender, null);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cont = false;
        }//stop
        double transform(double src, double min, double max)
        {
            double d = max - min;
            double result = src * d;//0...d
            result += min; //min...max
            return result;
        }
        private void textBoxLog_TextChanged(object sender, EventArgs e)
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
            MathExpectationAnalyzer analyzer = new MathExpectationAnalyzer(random.ToString());
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
            DispersionAnalyzer analyzer = new DispersionAnalyzer(random.ToString());
            analyzer.Show();
            listBoxAnalyzers.Items.Add(analyzer);
        }

        private void buttonAddDensityAnalyser_Click(object sender, EventArgs e)
        {
            DensityAnalyser analyzer = new DensityAnalyser(random.ToString());
            analyzer.Show();
            listBoxAnalyzers.Items.Add(analyzer);
        }

        private void buttonAddRepeatsAnalyzer_Click(object sender, EventArgs e)
        {
            RepeatsAnalyzer analyzer = new RepeatsAnalyzer(random.ToString());
            analyzer.Show();
            listBoxAnalyzers.Items.Add(analyzer);
        }

        private void buttonAddCycleAnalyzer_Click(object sender, EventArgs e)
        {
            CycleAnalyzer analyzer = new CycleAnalyzer(random.ToString());
            analyzer.Show();
            listBoxAnalyzers.Items.Add(analyzer);
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            while(listBoxAnalyzers.Items.Count > 0) { 
                ((Form)listBoxAnalyzers.Items[0]).Close();
                listBoxAnalyzers.Items.Remove(listBoxAnalyzers.Items[0]);
            }
        }

        private void buttonSwapCriteria_Click(object sender, EventArgs e)
        {
            SwapCriteriaAnalyzer analyzer = new SwapCriteriaAnalyzer(random.ToString());
            analyzer.Show();
            listBoxAnalyzers.Items.Add(analyzer);
        }

        private void buttonAddAutocorelationCriteria_Click(object sender, EventArgs e)
        {
            AutocorelationCriteriaAnalyzer analyzer = new AutocorelationCriteriaAnalyzer(random.ToString());
            analyzer.Show();
            listBoxAnalyzers.Items.Add(analyzer);
        }

        private void buttonAddEventTimeAnalyzer_Click(object sender, EventArgs e)
        {
            EventAppearAnalyzer analyzer = new EventAppearAnalyzer(random.ToString());
            analyzer.Show();
            listBoxAnalyzers.Items.Add(analyzer);
        }

        private void buttonGenerateOne_Click(object sender, EventArgs e)
        {
            generate();
        }

        private void MethodAnalyzeWindow_Load(object sender, EventArgs e)
        {
            buttonAddDensityAnalyser.Focus();
        }

        private void buttonAddLogGenerator_Click(object sender, EventArgs e)
        {
            LogCreatorAnalyzer analyzer = new LogCreatorAnalyzer();
            analyzer.Show();
            listBoxAnalyzers.Items.Add(analyzer);
        }
    }
}
