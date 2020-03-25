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

        RadioButton[] rb = new RadioButton[4];

        public Form2()
        {
            InitializeComponent();
            nextQuestion(null, null);

            rb[0] = radioButton1;
            rb[1] = radioButton2;
            rb[2] = radioButton3;
            rb[3] = radioButton4;
        }

        void cvetVsehOtvetov(Color color)
        {
            radioButton1.ForeColor = color;
            radioButton2.ForeColor = color;
            radioButton3.ForeColor = color;
            radioButton4.ForeColor = color;
        }

        void readFromFile(string vopros)
        {
            textBox1.Text = vopros + "?";
            try
            {
                string[] lines =
                    System.IO.File.ReadAllLines("../../Resources/" + vopros + ".txt");
                for (int i = 0; i < lines.Length; i++)
                    rb[i].Text = lines[i];

            }
            catch (Exception) { }
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
                readFromFile("Какая игра является одной из самых сложных в мире");
                try
                {
                    pictureBox1.Load("../../Resources/Dark Souls.jpg");
                }
                catch (Exception) { }
                cvetVsehOtvetov(Color.Black);
            }
            else if (nomer_voprosa == 2)
            {
                readFromFile("Какая игра является лучше пародеей на гта");
                try
                {
                    pictureBox1.Load("../../Resources/Saints Row.jpg");
                }
                catch (Exception) { }
                
                cvetVsehOtvetov(Color.Yellow);
            }
            else if (nomer_voprosa == 3)
            {
                readFromFile("Какой компании принадлежит игра The Whitcher");
                try
                {
                    pictureBox1.Load("../../Resources/The Witcher.jpg.jpg");
                }
                catch (Exception) { }
                
                cvetVsehOtvetov(Color.White);
            }
            else if (nomer_voprosa == 4)
            {
                
                try
                {
                    pictureBox1.Load("../../Resources/Prototype.jpg");
                }
                catch (Exception) { }
                textBox1.Text = "Как зовут главного героя Prototype";
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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
