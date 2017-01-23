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
    public partial class DispersionAnalyzer : Form, MethodAnalyzer
    {
        List<double> last = new List<double>();
        TimelineGraph mathExpectationGraph;
        string name;

        public DispersionAnalyzer(string name)
        {
            this.name = name;
            InitializeComponent();
            Text = "Дисперсія " + name;
            mathExpectationGraph = new TimelineGraph("Графік зміни дисперсії " + name);
            mathExpectationGraph.Show();
        }
        public void addNumber(double number)
        {
            last.Add(number);

            double sumD = 0;
            double sum = 0;
            for (int i = 0; i < last.Count; i++)
            {
                sum += last[i];
                sumD = sumD + (last[i]) * (last[i]);
            }
            sum = (sum * sum) / last.Count;
            double result = (sumD - sum) / last.Count;


            label2.Text = result.ToString();
            mathExpectationGraph.addNumber(result);
        }

        private void MathExpectationAnalyzer_Load(object sender, EventArgs e)
        {

        }
        public override string ToString()
        {
            return "Дисперсія " + name;
        }

        private void MathExpectationAnalyzer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mathExpectationGraph != null)
                mathExpectationGraph.Close();
        }
    }
}
