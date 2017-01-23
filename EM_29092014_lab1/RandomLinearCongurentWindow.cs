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
    public partial class RandomLinearCongurentWindow : Form
    {
        Form1.SetRandom setRandom = null;

        public RandomLinearCongurentWindow(Form1.SetRandom sr)
        {
            InitializeComponent();
            setRandom = sr;
            int m = Int32.Parse(textBoxM.Text);
            textBoxSeed.Text = (DateTime.Now.Millisecond % m).ToString();
            textBoxA.Text = (DateTime.Now.Millisecond % 10).ToString();
            textBoxC.Text = (DateTime.Now.Millisecond %30).ToString();
        }
        public RandomLinearCongurentWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int m = Int32.Parse(textBoxM.Text);
                int seed = Int32.Parse(textBoxSeed.Text);
                int a = Int32.Parse(textBoxA.Text);
                int c = Int32.Parse(textBoxC.Text);
                RandomLinearCongurent myRandom = new RandomLinearCongurent(a, c, m, seed);
                setRandom(myRandom);
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void RandomLevinWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
