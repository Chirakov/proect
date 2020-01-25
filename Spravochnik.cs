using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Spravochnik : Form
    {
        public Spravochnik()
        {
            InitializeComponent();
        }

        private void Spravochnik_Load(object sender, EventArgs e)
        {

        }

        void showSpravka(string textr)
        {
            Text = textr;
            MessageBox.Show(textr);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Spravka f = new Spravka("GTA");
            f.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Spravka f = new Spravka("Dark Souls");
            f.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Spravka f = new Spravka("Saints Row");
            f.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Spravka f = new Spravka("Prototype");
            f.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Spravka f = new Spravka("Witcher");
            f.Show();
        }
    }
}
