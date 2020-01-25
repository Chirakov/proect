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
    public partial class Spravka : Form
    {
        public Spravka(string game)
        {
            InitializeComponent();

            if (game == "Dark Souls")
            {
                pictureBox1.Load("../../Resources/DarkSouls.jpg");
                label1.Text = "Какая игра является одной из самых сложных в мире?";
            }
            if (game == "Saints Row")
            {
                pictureBox1.Load("../../Resources/Saints Row.jpg");
                label1.Text = "Какая игра является лучшей породией на гта?";
            }
            if (game == "Prototype")
            {
                pictureBox1.Load("../../Resources/Prototype.jpg");
                label1.Text = "Какая игра является лучшей породией на гта?";
            }
            if (game == "Witcher")
            {
                pictureBox1.Load("../../Resources/Witcher.jpg");
                label1.Text = "Какая игра является лучшей породией на гта?";
            }
        }

        private void Spravka_Load(object sender, EventArgs e)
        {

        }
    }
}
