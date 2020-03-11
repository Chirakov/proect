using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Spravka : Form
    {
        Game game;
        public Spravka(Game _game)
        {
            game = _game;
            InitializeComponent();

            Text = "Справка по игре " + game.name;
            
            opisanieTextBox.Text = game.zanr;
            priceTextBox.Text = game.price.ToString() + " рублей";
            steamLabel.Tag = game.steam.ToString() + "";

            try
            {
                pictureBox1.Load("../../Resources/" + game.name + ".jpg");
            }
            catch (Exception) { }
            try
            {
                opisanieTextBox.Text = File.ReadAllText("../../Resources/" + game + ".txt");
            }
            catch (Exception) { }
        }

        private void Spravka_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceTextBox_Click(object sender, EventArgs e)
        {

        }

        private void SteamLabel_Click(object sender, EventArgs e)
        {

        }

        private void SteamLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(steamLabel.Tag.ToString());
            }
            catch (Exception) { }
        }

        private void Vcorziny_Click(object sender, EventArgs e)
        {
            corzina.myChose.Add(game);
        }
    }
}
