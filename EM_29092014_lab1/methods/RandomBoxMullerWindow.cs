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
    public partial class RandomBoxMullerWindow : Form
    {
        MethodSelectWindow.SetRandom setRandom = null;

        public RandomBoxMullerWindow(MethodSelectWindow.SetRandom sr)
        {
            InitializeComponent();
            setRandom = sr;
        }
        public RandomBoxMullerWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//додати Cos
        {
            try
            {
                int n = Int32.Parse(textBoxN.Text);
                RandomBoxMullerCos myRandom = new RandomBoxMullerCos(n);
                setRandom(myRandom);
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)//додати Sin
        {
            try
            {
                int n = Int32.Parse(textBoxN.Text);
                RandomBoxMullerSin myRandom = new RandomBoxMullerSin(n);
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
