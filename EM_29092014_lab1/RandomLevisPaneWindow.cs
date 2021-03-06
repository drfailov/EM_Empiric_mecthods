﻿using System;
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
    public partial class RandomLevisPaneWindow : Form
    {
        Form1.SetRandom setRandom = null;

        public RandomLevisPaneWindow(Form1.SetRandom sr)
        {
            InitializeComponent();
            setRandom = sr;
        }
        public RandomLevisPaneWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int m = Int32.Parse(textBoxM.Text);
                int a = Int32.Parse(textBoxA.Text);
                int b = Int32.Parse(textBoxB.Text);
                RandomLevisPane myRandom = new RandomLevisPane(m, a, b);
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
