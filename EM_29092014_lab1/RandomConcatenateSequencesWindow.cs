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
    public partial class RandomConcatenateSequencesWindow : Form
    {
        Form1.SetRandom setRandom = null;

        public RandomConcatenateSequencesWindow(Form1.SetRandom sr)
        {
            InitializeComponent();
            setRandom = sr;            
        }
        public RandomConcatenateSequencesWindow()
        {
            InitializeComponent();
            textBoxSeed.Text = DateTime.Now.Millisecond.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//додати
        {
            try
            {
                Random rand = (Random)comboBoxMethod.SelectedItem;
                int m = Int32.Parse(textBoxM.Text);
                int seed = Int32.Parse(textBoxSeed.Text);
                RandomConcatenateSequences myRandom = new RandomConcatenateSequences(m, seed, rand);
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
            textBoxM.Text = "100";
            textBoxSeed.Text = (DateTime.Now.Millisecond % 100).ToString();
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
