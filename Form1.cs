﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты не админ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAge f = new FormAge();
            f.ShowDialog();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Spravochnik f = new Spravochnik();
            f.ShowDialog();
        }
    }
}
