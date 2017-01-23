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
    public partial class RandomKoveyWindow : Form
    {
        Form1.SetRandom setRandom = null;

        public RandomKoveyWindow(Form1.SetRandom sr)
        {
            InitializeComponent();
            setRandom = sr;
            textBoxSeed.Text = DateTime.Now.Millisecond.ToString();
        }
        public RandomKoveyWindow()
        {
            InitializeComponent();
            textBoxSeed.Text = DateTime.Now.Millisecond.ToString();
        }

        private void button1_Click(object sender, EventArgs e)//додати
        {
            try
            {
                int ee = Int32.Parse(textBoxE.Text);
                int seed = Int32.Parse(textBoxSeed.Text);
                RandomKovey myRandom = new RandomKovey(ee, seed);
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
