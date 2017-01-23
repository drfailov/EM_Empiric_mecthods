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
    public partial class RandomStandartNormalDistributionCentralEdgeTheoremaWindow : Form
    {
        MethodSelectWindow.SetRandom setRandom = null;

        public RandomStandartNormalDistributionCentralEdgeTheoremaWindow(MethodSelectWindow.SetRandom sr)
        {
            InitializeComponent();
            setRandom = sr;
        }
        public RandomStandartNormalDistributionCentralEdgeTheoremaWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//додати
        {
            try
            {
                int n = Int32.Parse(textBoxN.Text);
                RandomStandartNormalDistributionCentralEdgeTheorema myRandom = new RandomStandartNormalDistributionCentralEdgeTheorema(n);
                setRandom(myRandom);
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
    }
}
