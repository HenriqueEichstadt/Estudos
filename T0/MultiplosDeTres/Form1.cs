﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplosDeTres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int multiplosDeTres = 0;


            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    MessageBox.Show("O número  " + i +  "  É multiplo de 3");
                }
            }
        }
    }
}
