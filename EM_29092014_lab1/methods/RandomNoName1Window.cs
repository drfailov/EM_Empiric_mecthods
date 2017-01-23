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
    public partial class RandomNoName1Window : Form
    {
        MethodSelectWindow.SetRandom setRandom = null;

        public RandomNoName1Window(MethodSelectWindow.SetRandom sr)
        {
            InitializeComponent();
            setRandom = sr;
        }
        public RandomNoName1Window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//додати
        {
            try
            {
                int n = Int32.Parse(textBoxN.Text);
                RandomNoName1 myRandom = new RandomNoName1(n);
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
