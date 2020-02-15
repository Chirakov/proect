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
    public struct Game
    {
        public string name;
        public string zanr;
        public int price;
        public Button b;

        public Game(string name1, string zanr1, int price1, Button b1)
        {
            name = name1;
            zanr = zanr1;
            price = price1;
            b = b1;
        }
    }

    public partial class GamesList : Form
    {
        public Game[] games = new Game[2000];

        public GamesList()
        {
            InitializeComponent();


            games[0] = new Game("The Witcher", "Бродилка", 2000, button5);
            games[1] = new Game("Dark Souls", " Хардкор", 550,   button2);
            games[2] = new Game("Prototype", "Бродилка", 800, button4);
            games[3] = new Game("Saints Row", "Кооператив", 300, button3);
            games[4] = new Game("GTA", "Шутер", 1500, button1);
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

        private void GamesList_Load(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                games[i].b.Visible = true;
                if (textBox1.Text != "" &&
                    games[i].price < Convert.ToInt32(textBox1.Text))
                {
                    games[i].b.Visible = false;
                }

                if (checkedListBox1.CheckedItems.Count > 0)
                {
                    games[i].b.Visible = false;

                    for (int k = 0; k < checkedListBox1.CheckedItems.Count; k = k + 1)
                    {
                        if (checkedListBox1.CheckedItems[k].ToString() == games[i].zanr)
                            games[i].b.Visible = true;
                    }

                }
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            Button6_Click(null, null);
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             Button6_Click(null, null);
        }
    }
}
