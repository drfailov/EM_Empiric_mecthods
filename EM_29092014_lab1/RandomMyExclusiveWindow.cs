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
    public partial class RandomMyExclusiveWindow : Form
    {
        Form1.SetRandom setRandom = null;

        public RandomMyExclusiveWindow(Form1.SetRandom sr)
        {
            InitializeComponent();
            setRandom = sr;
        }
        public RandomMyExclusiveWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//додати
        {
            try
            {
                int time = Int32.Parse(textBoxTimeGeneration.Text);
                MyRandom myRandom = new RandomMyExclusive(time);
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
