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
        public string steam;
        public int price;
        public Button b;
        public Label l;

        public Game(string name1, string zanr1, int price1, string steam1)
        {
            steam = steam1;
            name = name1;
            zanr = zanr1;
            price = price1;
            b = new Button();
            l = new Label(); 
        }
    }

    public partial class GamesList : Form
    {
        public static Game[] games = new Game[7];
        public static Dictionary<Game , int games > games new Dictionary<Game, int >();
        
        public GamesList()
        {
            InitializeComponent();

            games[0] = new Game("The Witcher", "Бродилка", 2000, "https://steampay.com/game/the-witcher-3-wild-hunt-game-of-the-year-edition");
            games[1] = new Game("Dark Souls", " Хардкор", 550, "https://steampay.com/game/dark-souls");
            games[2] = new Game("Prototype", "Бродилка", 800, "https://steampay.com/game/prototype-2");
            games[3] = new Game("Saints Row", "Кооператив", 300, "https://store.steampowered.com/app/55230/Saints_Row_The_Third");
            games[4] = new Game("GTA V", "Шутер", 1500, "https://steampay.com/game/grand-theft-auto-v");
            games[5] = new Game("Mario", "Бродилка",338, "https://www.nintendo.ru/-/NES/Mario-Bros--768392.html");
            games[6] = new Game("Rust", "Кооператив", 975, "https://steampay.com/game/rust");

            int x = 10;
            int y = 100;
            for (int i = 0; i < games.Length; i++)
                foreach (KeyValuePair<Game, int> myGame in corzina.games)
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



                games[i].l.Location = new Point(x, y + 75);
                games[i].l.Size = new Size(125, 25);
                games[i].l.Text = games[i].price.ToString() + " рублей";
                games[i].l.Font = new Font("Microsoft Sans Serif", 11F);
                Controls.Add(games[i].l);


                x = x + 130;
                if (x + 125 > Width)
                {
                    x = 10;
                    y = y + 100;
                }
            }
        }

        public static void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < games.Length; i++)
            {
                if (((Button)sender).Text == games[i].b.Text)
                {
                    Spravka f = new Spravka(games[i]);
                    f.Show();
                }
            }
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

        private void Корзина_Click(object sender, EventArgs e)
        {
            corzina f = new corzina();
            f.Show();
            if (!corzina.games.Contains(Game))
                corzina.games.Add(Game);
        }
    }
}
