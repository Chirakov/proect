namespace WindowsFormsApp8
{
    partial class Spravka
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.opisanieTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.Label();
            this.steamLabel = new System.Windows.Forms.LinkLabel();
            this.vcorziny = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(658, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // opisanieTextBox
            // 
            this.opisanieTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.opisanieTextBox.Enabled = false;
            this.opisanieTextBox.Location = new System.Drawing.Point(26, 12);
            this.opisanieTextBox.Multiline = true;
            this.opisanieTextBox.Name = "opisanieTextBox";
            this.opisanieTextBox.ReadOnly = true;
            this.opisanieTextBox.Size = new System.Drawing.Size(531, 35);
            this.opisanieTextBox.TabIndex = 2;
            this.opisanieTextBox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTextBox.AutoSize = true;
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(554, 12);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(64, 25);
            this.priceTextBox.TabIndex = 4;
            this.priceTextBox.Text = "Цена";
            this.priceTextBox.Click += new System.EventHandler(this.PriceTextBox_Click);
            // 
            // steamLabel
            // 
            this.steamLabel.AutoSize = true;
            this.steamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.steamLabel.Location = new System.Drawing.Point(477, 15);
            this.steamLabel.Name = "steamLabel";
            this.steamLabel.Size = new System.Drawing.Size(61, 22);
            this.steamLabel.TabIndex = 6;
            this.steamLabel.TabStop = true;
            this.steamLabel.Text = "Steam";
            this.steamLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SteamLabel_LinkClicked);
            // 
            // vcorziny
            // 
            this.vcorziny.Location = new System.Drawing.Point(401, 16);
            this.vcorziny.Name = "vcorziny";
            this.vcorziny.Size = new System.Drawing.Size(70, 21);
            this.vcorziny.TabIndex = 7;
            this.vcorziny.Text = "в корзину";
            this.vcorziny.UseVisualStyleBackColor = true;
            this.vcorziny.Click += new System.EventHandler(this.Vcorziny_Click);
            // 
            // Spravka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 323);
            this.Controls.Add(this.vcorziny);
            this.Controls.Add(this.steamLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.opisanieTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Spravka";
            this.Text = "Spravka";
            this.Load += new System.EventHandler(this.Spravka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox opisanieTextBox;
        private System.Windows.Forms.Label priceTextBox;
        private System.Windows.Forms.LinkLabel steamLabel;
        private System.Windows.Forms.Button vcorziny;
    }
}