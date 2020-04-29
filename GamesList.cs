using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

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
        public static List< Game> games = new List< Game>();

        public GamesList()
        {
            InitializeComponent();

            
            string[] lines = System.IO.File.ReadAllLines("Игры.txt");
            foreach (string str in lines)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                games.Add(new Game(parts[0], parts[1], Convert.ToInt32(parts[2]), parts[3]));
            }
            int x = 10;
            int y = 100;
            for (int i = 0; i < games.Count; i++)
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
            for (int i = 0; i < games.Count; i++)
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

        private void button2_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("chirakov77@gmail.com");
            MailAddress toAddress = new MailAddress("chirakov77@gmail.com");

            using (MailMessage mailMessage = new MailMessage(fromMailAddress, toAddress))
            using (SmtpClient smtpClient = new SmtpClient())
            {
                MailMessage.Subject = "Привет";
                MailMessage.Body = "А вот и список Машин";
                MailMessage.Attachments.Add(new Attachment("Игры.txt"));

                smtpClient.Host = "";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "Vb[fbkCthuttdbxF,hfvjd");

                smtpClient.Send(mailMessage);

            }
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 100;
            for (int i = 0; i < games.Count; i++)
            {
                games[i].b.Visible = true;
                games[i].l.Visible = true;

                //Проверяем цену
                try
                {
                    if (textBox1.Text != "" &&
                        games[i].price > Convert.ToInt32(textBox1.Text))
                    {
                        games[i].b.Visible = false;
                        games[i].l.Visible = false;
                    }
                }
                catch (Exception) { }

                //Поиск по слову
                if (searchTextBox.Text != "" &&
                    !games[i].name.ToLower().Contains(searchTextBox.Text.ToLower()))
                {
                    games[i].b.Visible = false;
                    games[i].l.Visible = false;
                }

                //Жанр игры проверяем
                if (checkedListBox1.CheckedItems.Count > 0)
                {
                    games[i].b.Visible = false;
                    games[i].l.Visible = false;
                    if (checkedListBox1.CheckedItems.Contains(games[i].zanr))
                    { 
                        games[i].b.Visible = true;
                        games[i].l.Visible = true;
                    }
                }


                if (games[i].b.Visible)
                {
                    games[i].b.Location = new Point(x, y);
                    games[i].l.Location = new Point(x, y + 75);

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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form7 form  = new Form7();
            form.Show();
        }
}
}
