using System;
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
    public partial class Form2 : Form
    {
        int nomer_voprosa = 0;

        public Form2()
        {
            InitializeComponent();
            nextQuestion(null, null);
        }

        private void nextQuestion(object sender, EventArgs e)
        {
            nomer_voprosa = nomer_voprosa + 1;
            if (nomer_voprosa == 1)
            {
                pictureBox1.Load("../../Resources/DarkSouls.jpg");
                textBox1.Text = "Какая игра является одной из самых сложных в мире?";
                radioButton1.Text = "Dark Souls";
            }
            else if (nomer_voprosa == 2)
            {
                pictureBox1.Load("../../Resources/Saints Row.jpg");
                textBox1.Text = "Какая игра является лучше пародеей на гта?";
                radioButton1.Text = "Saints Row";
                radioButton2.Text = "Watch Dogs";
                radioButton3.Text = "Sleeping Dogs";
                radioButton4.Text = "Prototype";
            }
            else
            {
                Form3 form = new Form3();
                form.ShowDialog();
            }

            BackgroundImage = pictureBox1.Image;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
