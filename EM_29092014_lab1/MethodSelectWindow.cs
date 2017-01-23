﻿using System;
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
    public partial class MethodSelectWindow : Form
    {
        MyRandom currentRandom = new MyRandom();
        public delegate void SetRandom(MyRandom mr);
        double timeStart;

        public MethodSelectWindow()
        {
            InitializeComponent();
            log("");
        }
        void setRandom(MyRandom r)
        {
            currentRandom = r;
            currentRandom.setLog(log);
            labelCurrentRandom.Text = r.ToString();
            labelCurrentRandom.BackColor = Color.LightGreen;
        }
        void output(string text)
        {
            if (checkBoxLog.Checked)
            {
                textBoxLog.AppendText(text);
                if (checkBoxCarette.Checked && text.Contains('\n'))
                    textBoxLog.ScrollToCaret();
                Application.DoEvents();
            }
        }
        void log(String text)
        {
            output(text + "\n");
        }
        void timeBegin()
        {
            timeStart = DateTime.Now.TimeOfDay.TotalMilliseconds;
        }
        void timeEnd()
        {
            double timeFinish = DateTime.Now.TimeOfDay.TotalMilliseconds;
            labelStatus.Text = "Час виконання операції: " + ((timeFinish - timeStart).ToString("n")) + " мс.";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonExclusive.Focus();
        }
        private void buttonLeonidLevin_Click(object sender, EventArgs e)//Метод Леоніда Левіна
        {
            new RandomLevinWindow(setRandom).Show();
        }
        private void buttonLinearCongurent_Click(object sender, EventArgs e)//Линейный конгурентный метод
        {
            new RandomLinearCongurentWindow(setRandom).Show();
        }
        private void buttonKovey_Click(object sender, EventArgs e)//додати метод Ковея
        {
            new RandomKoveyWindow(setRandom).Show();
        }
        private void buttonExclusive_Click(object sender, EventArgs e)//додати ексключизний метод
        {
            new RandomMyExclusiveWindow(setRandom).Show();
        }
        private void buttonSystem_Click(object sender, EventArgs e)//додати системний метод
        {
            setRandom(new MyRandom());
        }
        private void buttonGenerate_Click(object sender, EventArgs e)//generate
        {
            log("Генеруємо нове число методом " + currentRandom.ToString() + " ...");
            int num = currentRandom.Next();
            log("Результат генерування: " + num + ".");
        }
        private void buttonGraphic_Click(object sender, EventArgs e)//будувати графік
        {
            new MethodAnalyzeWindow(currentRandom).Show();
        }

        private void buttonLevisPane_Click(object sender, EventArgs e)
        {
            new RandomLevisPaneWindow(setRandom).Show();
        }

        private void buttonSeqConc_Click(object sender, EventArgs e)
        {
            new RandomConcatenateSequencesWindow(setRandom).Show();
        }

        private void button2_Click(object sender, EventArgs e)//BoxMuller
        {
            new RandomBoxMullerWindow(setRandom).Show();
        }

        private void buttonNoName1_Click(object sender, EventArgs e)//нонейм
        {
            new RandomStandartNormalDistributionCentralEdgeTheoremaWindow(setRandom).Show();
        }

        private void buttonBoxMullerBinary_Click(object sender, EventArgs e)//двійковий бокса-мюллера
        {
            setRandom(new RandomBoxMullerSinBinary());
        }

        private void labelCurrentRandom_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(labelCurrentRandom.Text);
            labelStatus.Text = "Text copied.";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBoxLog.Clear();
        }

        private void buttonAddPuasonFlow_Click(object sender, EventArgs e)
        {
            new RandomPuassoFlowWindow(setRandom).Show();
        }

        private void buttonAddExpMethod_Click(object sender, EventArgs e)
        {
            new RandomExponentialDistributionWindow(setRandom).Show();
        }

        private void buttonAddBilonialMethod_Click(object sender, EventArgs e)
        {
            new RandomBinomialDistributionWindow(setRandom).Show();
        }

        private void buttonAddBarsaliBrey_Click(object sender, EventArgs e)
        {
            new RandomStandartNormalDistributionBarsaliBreyWindow(setRandom).Show();
        }

        private void buttonAddHi2Distribution_Click(object sender, EventArgs e)
        {
            new RandomHi2DistributionWindow(setRandom).Show();
        }

        private void buttonAddFisherDistribution_Click(object sender, EventArgs e)
        {
            new RandomFisherSnedekorWindow(setRandom).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Виконав: студент групи КП-11, Папуша Роман Олегович\n"+
                "В рамках дисципліни: \"Емпіричні методи\" 2014 року.\n"+
                "Викладач: Онай Микола Володимирович \n"+
                "Київ-2014");
        }
    }
}
