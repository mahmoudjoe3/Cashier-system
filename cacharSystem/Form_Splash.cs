﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cacharSystem
{
    public partial class Form_Splash : Form
    {
        int move;
        public Form_Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSlide.Left += 2;
            if (panelSlide.Left > 270)
            {
                panelSlide.Left = 0;
            }
            if (panelSlide.Left < 0)
            {
                move = 2;
            }
        }

        private void Form_Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
