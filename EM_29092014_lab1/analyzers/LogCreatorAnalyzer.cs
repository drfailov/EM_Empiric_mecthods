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
    public partial class LogCreatorAnalyzer : Form, MethodAnalyzer
    {
        public LogCreatorAnalyzer()
        {
            InitializeComponent();
        }
        public void addNumber(double number)
        {
            richTextBox1.Text = richTextBox1.Text + "\nx = " + number.ToString();
        }
        public override string ToString()
        {
            return "Генератор логу";
        }
    }
}
