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
    public partial class RandomHi2DistributionWindow : Form
    {
        MethodSelectWindow.SetRandom setRandom = null;

        public RandomHi2DistributionWindow(MethodSelectWindow.SetRandom sr)
        {
            InitializeComponent();
            setRandom = sr;            
        }
        public RandomHi2DistributionWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//додати
        {
            try
            {
                Random rand = (Random)comboBoxMethod.SelectedItem;
                int n = Int32.Parse(textBoxN.Text);
                RandomHi2Distribution myRandom = new RandomHi2Distribution(rand, n);
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
            comboBoxMethod.Items.Add(new RandomStandartNormalDistributionBarsaliBrey());
            comboBoxMethod.Items.Add(new RandomStandartNormalDistributionCentralEdgeTheorema());
            comboBoxMethod.SelectedIndex = 0;
        }
    }
}
