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
    public partial class RandomStandartNormalDistributionBarsaliBreyWindow : Form
    {
        MethodSelectWindow.SetRandom setRandom = null;

        public RandomStandartNormalDistributionBarsaliBreyWindow(MethodSelectWindow.SetRandom sr)
        {
            InitializeComponent();
            setRandom = sr;            
        }
        public RandomStandartNormalDistributionBarsaliBreyWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//додати
        {
            try
            {
                Random rand = (Random)comboBoxMethod.SelectedItem;
                RandomStandartNormalDistributionBarsaliBrey myRandom = new RandomStandartNormalDistributionBarsaliBrey(rand);
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
            comboBoxMethod.Items.Add(new MyRandom());
            comboBoxMethod.Items.Add(new RandomKovey());
            comboBoxMethod.Items.Add(new RandomLevin());
            comboBoxMethod.Items.Add(new RandomLevisPane());
            comboBoxMethod.Items.Add(new RandomLinearCongurent());
            comboBoxMethod.Items.Add(new RandomMyExclusive());
            comboBoxMethod.SelectedIndex = 1;
        }
    }
}
