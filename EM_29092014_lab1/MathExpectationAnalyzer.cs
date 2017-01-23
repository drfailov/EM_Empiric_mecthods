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
    public partial class MathExpectationAnalyzer : Form, MethodAnalyzer
    {
        List<double> last = new List<double>();
        TimelineGraph mathExpectationGraph;
        string name;

        public MathExpectationAnalyzer(string name)
        {
            this.name = name;
            InitializeComponent();
            Text = "Мат очікування " + name;
            mathExpectationGraph = new TimelineGraph("Графік зміни математичного очікування " + name);
            mathExpectationGraph.Show();
        }
        public void addNumber(double number)
        {
            last.Add(number);
            double sum = 0;
            foreach (double d in last)
                sum += d;
            double me = sum / (double)last.Count;
            label2.Text = me.ToString();
            mathExpectationGraph.addNumber(me);
        }

        private void MathExpectationAnalyzer_Load(object sender, EventArgs e)
        {

        }
        public override string ToString()
        {
            return "Математичне очікування " + name;
        }

        private void MathExpectationAnalyzer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mathExpectationGraph != null)
                mathExpectationGraph.Close();
        }
    }
}
