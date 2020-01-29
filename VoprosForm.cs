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

        void cvetVsehOtvetov(Color color)
        {
            radioButton1.ForeColor = color;
            radioButton2.ForeColor = color;
            radioButton3.ForeColor = color;
            radioButton4.ForeColor = color;
        }




        private void nextQuestion(object sender, EventArgs e)
        {
            if (!radioButton1.Checked &&
                !radioButton2.Checked &&
                !radioButton3.Checked &&
                !radioButton4.Checked)
            {
                return;
            }

            nomer_voprosa = nomer_voprosa + 1;
            if (nomer_voprosa == 1)
            {
                pictureBox1.Load("../../Resources/DarkSouls.jpg");
                textBox1.Text = "Какая игра является одной из самых сложных в мире?";
                radioButton1.Text = "Dark Souls";
                cvetVsehOtvetov(Color.Black);
            }
            else if (nomer_voprosa == 2)
            {
                pictureBox1.Load("../../Resources/Saints Row.jpg");
                textBox1.Text = "Какая игра является лучше пародеей на гта?";
                radioButton1.Text = "Saints Row";
                radioButton2.Text = "Watch Dogs";
                radioButton3.Text = "Sleeping Dogs";
                radioButton4.Text = "Prototype";
                cvetVsehOtvetov(Color.Yellow);
            }
            else if (nomer_voprosa == 3)
            {
                pictureBox1.Load("../../Resources/Witcher.jpg");
                textBox1.Text = "Какой компании принадлежит игра The Whitcher?";
                radioButton1.Text = "Rockstar Games";
                radioButton2.Text = "Ubisoft";
                radioButton3.Text = "From Software";
                radioButton4.Text = "CD Project";
                cvetVsehOtvetov(Color.White);
            }
            else if (nomer_voprosa == 4)
            {
                pictureBox1.Load("../../Resources/Prototype.jpg");
                textBox1.Text = "Как зовут главного героя Prototype";
                radioButton1.Text = "Филип Киркоров";
                radioButton2.Text = "Джонни";
                radioButton3.Text = "Алекс Мерсер";
                radioButton4.Text = "Карл Джонсон";
                cvetVsehOtvetov(Color.White);
            }
            else
            {
                MessageBox.Show("Вы победили");
                Close();
            }

            BackgroundImage = pictureBox1.Image;
            label1.Text = "Вопрос " + nomer_voprosa.ToString();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
