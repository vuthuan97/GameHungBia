﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_ExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_playGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new Form();
            frm.Show();
        }
    }
}
