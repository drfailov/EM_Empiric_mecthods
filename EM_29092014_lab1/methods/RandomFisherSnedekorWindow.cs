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
    public partial class RandomFisherSnedekorWindow : Form
    {
        MethodSelectWindow.SetRandom setRandom = null;

        public RandomFisherSnedekorWindow(MethodSelectWindow.SetRandom sr)
        {
            InitializeComponent();
            setRandom = sr;            
        }
        public RandomFisherSnedekorWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//додати
        {
            try
            {
                int k1 = Int32.Parse(textBoxK1.Text);
                int k2 = Int32.Parse(textBoxK2.Text);
                RandomFisherSnedekor myRandom = new RandomFisherSnedekor(k1, k2);
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
        }
    }
}
