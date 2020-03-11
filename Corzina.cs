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
    public partial class corzina : Form
    {
        public static List<Game> myChose = new List<Game>();

        public corzina()
        {
            InitializeComponent();

            foreach (Game game in corzina.myChose)
            {
                Label lbl = new Label();
                lbl = game.l;
                lbl.Location = game.l.Location;
                lbl.Size = game.l.Size;
                lbl.Text = game.l.Text;
                lbl.Font = game.l.Font;

                Button btn = new Button();
                btn.Location = game.b.Location;
                btn.Size = game.b.Size;
                btn.Text = game.b.Text;
                btn.Font = game.b.Font;
                btn.ForeColor = game.b.ForeColor;
                btn.BackgroundImage = game.b.BackgroundImage;
                btn.BackgroundImageLayout = game.b.BackgroundImageLayout;
                btn.Click += new EventHandler(GamesList.Button1_Click);
                Controls.Add(lbl);
                Controls.Add(btn);
            }
        }

        private void Corzina_Load(object sender, EventArgs e)
        {

        }
    }
}
