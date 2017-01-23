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
    public partial class RandomBinomialDistributionWindow : Form
    {
        MethodSelectWindow.SetRandom setRandom = null;

        public RandomBinomialDistributionWindow(MethodSelectWindow.SetRandom sr)
        {
            InitializeComponent();
            setRandom = sr;            
        }
        public RandomBinomialDistributionWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//додати
        {
            try
            {
                Random rand = (Random)comboBoxMethod.SelectedItem;
                double n = Double.Parse(textBoxN.Text);
                double p = Double.Parse(textBoxP.Text);
                RandomBinomialDistribution myRandom = new RandomBinomialDistribution(n, p, rand);
                setRandom(myRandom);
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void RandomConcatenateSequencesWindow_Load(object sender, EventArgs e)
        {
            textBoxN.Text = "100";
            textBoxP.Text = "0,5";
            comboBoxMethod.Items.Add(new MyRandom());
            comboBoxMethod.Items.Add(new RandomKovey());
            comboBoxMethod.Items.Add(new RandomLevin());
            comboBoxMethod.Items.Add(new RandomLevisPane());
            comboBoxMethod.Items.Add(new RandomLinearCongurent());
            comboBoxMethod.Items.Add(new RandomMyExclusive());
            comboBoxMethod.SelectedIndex = 1;
        }
    }
}
