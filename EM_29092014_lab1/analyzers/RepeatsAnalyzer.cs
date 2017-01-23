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
    public partial class RepeatsAnalyzer : Form, MethodAnalyzer
    {
        int total = 0;
        int repeats = 0;
        double last = 0;
        TimelineGraph mathExpectationGraph = null;
        string name;

        public RepeatsAnalyzer(string name)
        {
            this.name = name;
            InitializeComponent();
            Text = ToString();
        }
        public void addNumber(double number)
        {
            total++;
            if (last == number)
                repeats++;
            double result = ((double)repeats * 100d) / (double)total;
            label2.Text = (int)result + "%";
            if(mathExpectationGraph != null)
                mathExpectationGraph.addNumber(result);
            last = number;
        }

        private void MathExpectationAnalyzer_Load(object sender, EventArgs e)
        {

        }
        public override string ToString()
        {
            return "Кількість повторів " + name;
        }

        private void MathExpectationAnalyzer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mathExpectationGraph != null)
                mathExpectationGraph.Close();
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            mathExpectationGraph = new TimelineGraph("Графік зміни " + ToString());
            mathExpectationGraph.Show();
        }
    }
}
