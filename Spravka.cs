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
        public Spravka(string game, int price, string steam)
        {
            InitializeComponent();

            Text = "Справка по игре " + game;
            priceTextBox.Text = price.ToString() + " рублей";
            steamLabel.Tag = steam.ToString() + "";

            try
            {
                pictureBox1.Load("../../Resources/" + game + ".jpg");
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
    }
}
