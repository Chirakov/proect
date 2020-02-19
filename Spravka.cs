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

            Text = "Справка по игре " + game;

            if (game == "Dark Souls")
            {
                pictureBox1.Load("../../Resources/" + game + ".jpg");
                textBox1.Text = "Игра которая не имеет прямого сюжета и заставит тебя забросить ее в первые 5 минут игры";
            }
            if (game == "Saints Row")
            {
                pictureBox1.Load("../../Resources/Saints Row.jpg");
                textBox1.Text = "Игра которая превзошла все свои ожидание, получилась лучше чем GTA";
            }
            if (game == "Prototype")
            {
                pictureBox1.Load("../../Resources/Prototype.jpg");
                textBox1.Text = "Тоже хорошая игра но сюжет короткий";
            }
            if (game == "Witcher")
            {
                pictureBox1.Load("../../Resources/Witcher.jpg");
                textBox1.Text = "Это убийца не только монстров но и всей игровой индустрии";
            }
            if (game == "GTA")
            {
                pictureBox1.Load("../../Resources/GTA.jpg");
                textBox1.Text = "худшая игра всей серии";
            }
        }

        private void Spravka_Load(object sender, EventArgs e)
        {

        }
    }
}
