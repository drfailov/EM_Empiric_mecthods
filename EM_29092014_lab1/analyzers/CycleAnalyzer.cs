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
    public partial class CycleAnalyzer : Form, MethodAnalyzer
    {
        string name;
        int maximumCycle = 0;
        int minimumCycleDistance = -1;
        List<double> numbers = new List<double>();

        public CycleAnalyzer(string name)
        {
            this.name = name;
            InitializeComponent();
            Text = ToString();
        }
        public void addNumber(double number)
        {
            if (labelCycleFound.Visible)
                return;
            numbers.Add(number);
            int cycleTheshold = Int32.Parse(textBoxСycleThreshold.Text);
            for (int i = 0; i < numbers.Count; i++)
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
                        if (repeatCnt > 0 && repeatCnt > maximumCycle)
                        {
                            //вивести проблемні числа
                            String nums = "";
                            for (int k = 0; k < cycleTheshold; k++)
                                nums += numbers[i + k] + "(id=" + (i + k) + ")" + "  |  " + numbers[j + k] + "(id=" + (j + k) + ")   \n";
                            maximumCycle = repeatCnt;
                            labelRepeatingNumbers.Text = nums;
                            labelLongestCycle.Text = maximumCycle.ToString();
                        }
                        if (repeatCnt >= cycleTheshold)// FOUND CYCLE
                        {
                            labelCycleFound.Visible = true;
                            //вивести відстань циклу
                            int distance = j - i;
                            if (minimumCycleDistance == -1 || distance < minimumCycleDistance)
                            {
                                minimumCycleDistance = distance;
                                labelShortestDistance.Text = minimumCycleDistance.ToString(); ;
                            };
                            //завершити аналіз
                            break;
                        }
                        offset++;
                    }
                }
            }
            Application.DoEvents();
        }

        private void MathExpectationAnalyzer_Load(object sender, EventArgs e)
        {

        }
        public override string ToString()
        {
            return "Аналізатор циклів " + name;
        }

        private void MathExpectationAnalyzer_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
