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
    public partial class RandomPuassoFlowWindow : Form
    {
        MethodSelectWindow.SetRandom setRandom = null;

        public RandomPuassoFlowWindow(MethodSelectWindow.SetRandom sr)
        {
            InitializeComponent();
            setRandom = sr;
        }
        public RandomPuassoFlowWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//додати 2
        {
            try
            {
                int lambda = Int32.Parse(textBoxN.Text);
                RandomPuassonFlow myRandom = new RandomPuassonFlow(lambda, 2);
                setRandom(myRandom);
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int lambda = Int32.Parse(textBoxN.Text);
                RandomPuassonFlow myRandom = new RandomPuassonFlow(lambda, 0);
                setRandom(myRandom);
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                int lambda = Int32.Parse(textBoxN.Text);
                RandomPuassonFlow myRandom = new RandomPuassonFlow(lambda, 1);
                setRandom(myRandom);
                Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                int lambda = Int32.Parse(textBoxN.Text);
                RandomPuassonFlow myRandom = new RandomPuassonFlow(lambda, 3);
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
