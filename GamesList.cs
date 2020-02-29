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

        public Game(string name1, string zanr1, int price1)
        {
            name = name1;
            zanr = zanr1;
            price = price1;
            b = new Button();
        }
    }

    public partial class GamesList : Form
    {
        public Game[] games = new Game[7];

        public GamesList()
        {
            InitializeComponent();


            games[0] = new Game("The Witcher", "Бродилка", 2000);
            games[1] = new Game("Dark Souls", " Хардкор", 550);
            games[2] = new Game("Prototype", "Бродилка", 800);
            games[3] = new Game("Saints Row", "Кооператив", 300);
            games[4] = new Game("GTA V", "Шутер", 1500);
            games[5] = new Game("Mario", "Бродилка",338);
            games[6] = new Game("Rust", "Кооператив", 975);

            int x = 10;
            int y = 100;
            for (int i = 0; i < games.Length; i++)
            {
                games[i].b.Location = new Point(x, y);
                games[i].b.Size = new Size(125, 75);
                games[i].b.Text = games[i].name;
                games[i].b.Font = new Font("Microsoft Sans Serif", 13F);
                games[i].b.ForeColor = SystemColors.ButtonHighlight;
                games[i].b.Click += new EventHandler(Button1_Click);
                PictureBox PB = new PictureBox();
                try
                {
                    PB.Load("../../Resources/" + games[i].name + ".jpg");
                    games[i].b.BackgroundImage = PB.Image;
                    games[i].b.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception) { }

                Controls.Add(games[i].b);
                x = x + 130;
                if (x + 125 > Width)
                {
                    x = 10;
                    y = y + 100;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button buttonz = (Button)sender;
            Spravka f = new Spravka(buttonz.Text);
            f.Show();
        }


        private void GamesList_Load(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 100;
            for (int i = 0; i < games.Length; i++)
            {
                games[i].b.Visible = true;

                //Проверяем цену
                try
                {
                    if (textBox1.Text != "" &&
                        games[i].price > Convert.ToInt32(textBox1.Text))
                    {
                        games[i].b.Visible = false;
                    }
                }
                catch (Exception) { }

                //Поиск по слову
                if (searchTextBox.Text != "" &&
                    !games[i].name.ToLower().Contains(searchTextBox.Text.ToLower()))
                {
                    games[i].b.Visible = false;
                }

                //Жанр игры проверяем
                if (checkedListBox1.CheckedItems.Count > 0)
                {
                    games[i].b.Visible = false;
                    if (checkedListBox1.CheckedItems.Contains(games[i].zanr))
                    { 
                        games[i].b.Visible = true;
                    }
                }


                if (games[i].b.Visible)
                {
                    games[i].b.Location = new Point(x, y);

                    x = x + 130;
                    if (x + 125 > Width)
                    {
                        x = 10;
                        y = y + 100;
                    }
                }
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Button6_Click(null, null);
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             Button6_Click(null, null);
        }
    }
}
