namespace Hiragana_Training
{
    partial class KanaTraining
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KanaTraining));
            this.OutputHira = new System.Windows.Forms.RichTextBox();
            this.Outputtranshira = new System.Windows.Forms.RichTextBox();
            this.OutputKata = new System.Windows.Forms.RichTextBox();
            this.Outputtradkata = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Inputhira = new System.Windows.Forms.RichTextBox();
            this.inputkata = new System.Windows.Forms.RichTextBox();
            this.CheckHira = new System.Windows.Forms.Button();
            this.CheckKata = new System.Windows.Forms.Button();
            this.NextHira = new System.Windows.Forms.Button();
            this.NextKata = new System.Windows.Forms.Button();
            this.htoroma = new System.Windows.Forms.TextBox();
            this.traduzioneh = new System.Windows.Forms.TextBox();
            this.traduzionek = new System.Windows.Forms.TextBox();
            this.ktoroma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputHira
            // 
            this.OutputHira.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.OutputHira.Location = new System.Drawing.Point(32, 116);
            this.OutputHira.Name = "OutputHira";
            this.OutputHira.Size = new System.Drawing.Size(183, 56);
            this.OutputHira.TabIndex = 0;
            this.OutputHira.Text = "";
            this.OutputHira.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // Outputtranshira
            // 
            this.Outputtranshira.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Outputtranshira.Enabled = false;
            this.Outputtranshira.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Outputtranshira.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Outputtranshira.Location = new System.Drawing.Point(32, 207);
            this.Outputtranshira.Name = "Outputtranshira";
            this.Outputtranshira.Size = new System.Drawing.Size(183, 59);
            this.Outputtranshira.TabIndex = 1;
            this.Outputtranshira.Text = "";
            this.Outputtranshira.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // OutputKata
            // 
            this.OutputKata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.OutputKata.Location = new System.Drawing.Point(484, 116);
            this.OutputKata.Name = "OutputKata";
            this.OutputKata.Size = new System.Drawing.Size(183, 56);
            this.OutputKata.TabIndex = 2;
            this.OutputKata.Text = "";
            this.OutputKata.TextChanged += new System.EventHandler(this.RichTextBox2_TextChanged);
            // 
            // Outputtradkata
            // 
            this.Outputtradkata.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Outputtradkata.Enabled = false;
            this.Outputtradkata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Outputtradkata.Location = new System.Drawing.Point(484, 207);
            this.Outputtradkata.Name = "Outputtradkata";
            this.Outputtradkata.Size = new System.Drawing.Size(183, 59);
            this.Outputtradkata.TabIndex = 3;
            this.Outputtradkata.Text = "";
            this.Outputtradkata.TextChanged += new System.EventHandler(this.Outputtradkata_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(484, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Inputhira
            // 
            this.Inputhira.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Inputhira.Location = new System.Drawing.Point(32, 312);
            this.Inputhira.Name = "Inputhira";
            this.Inputhira.Size = new System.Drawing.Size(183, 76);
            this.Inputhira.TabIndex = 6;
            this.Inputhira.Text = "";
            this.Inputhira.TextChanged += new System.EventHandler(this.RichTextBox4_TextChanged);
            // 
            // inputkata
            // 
            this.inputkata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.inputkata.Location = new System.Drawing.Point(484, 312);
            this.inputkata.Name = "inputkata";
            this.inputkata.Size = new System.Drawing.Size(183, 76);
            this.inputkata.TabIndex = 7;
            this.inputkata.Text = "";
            this.inputkata.TextChanged += new System.EventHandler(this.Inputkata_TextChanged);
            // 
            // CheckHira
            // 
            this.CheckHira.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckHira.BackgroundImage")));
            this.CheckHira.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckHira.Location = new System.Drawing.Point(221, 312);
            this.CheckHira.Name = "CheckHira";
            this.CheckHira.Size = new System.Drawing.Size(103, 76);
            this.CheckHira.TabIndex = 8;
            this.CheckHira.UseVisualStyleBackColor = true;
            this.CheckHira.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CheckKata
            // 
            this.CheckKata.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CheckKata.BackgroundImage")));
            this.CheckKata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CheckKata.Location = new System.Drawing.Point(685, 312);
            this.CheckKata.Name = "CheckKata";
            this.CheckKata.Size = new System.Drawing.Size(103, 76);
            this.CheckKata.TabIndex = 9;
            this.CheckKata.UseVisualStyleBackColor = true;
            this.CheckKata.Click += new System.EventHandler(this.CheckKata_Click);
            // 
            // NextHira
            // 
            this.NextHira.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextHira.BackgroundImage")));
            this.NextHira.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NextHira.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NextHira.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NextHira.Location = new System.Drawing.Point(221, 116);
            this.NextHira.Name = "NextHira";
            this.NextHira.Size = new System.Drawing.Size(103, 56);
            this.NextHira.TabIndex = 10;
            this.NextHira.UseVisualStyleBackColor = true;
            this.NextHira.Click += new System.EventHandler(this.Button3_Click);
            // 
            // NextKata
            // 
            this.NextKata.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextKata.BackgroundImage")));
            this.NextKata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NextKata.Location = new System.Drawing.Point(685, 116);
            this.NextKata.Name = "NextKata";
            this.NextKata.Size = new System.Drawing.Size(103, 56);
            this.NextKata.TabIndex = 11;
            this.NextKata.UseVisualStyleBackColor = true;
            this.NextKata.Click += new System.EventHandler(this.Button4_Click);
            // 
            // htoroma
            // 
            this.htoroma.Location = new System.Drawing.Point(12, 513);
            this.htoroma.Name = "htoroma";
            this.htoroma.Size = new System.Drawing.Size(118, 22);
            this.htoroma.TabIndex = 12;
            this.htoroma.Visible = false;
            this.htoroma.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // traduzioneh
            // 
            this.traduzioneh.Location = new System.Drawing.Point(12, 485);
            this.traduzioneh.Name = "traduzioneh";
            this.traduzioneh.Size = new System.Drawing.Size(118, 22);
            this.traduzioneh.TabIndex = 13;
            this.traduzioneh.Visible = false;
            this.traduzioneh.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            // 
            // traduzionek
            // 
            this.traduzionek.Location = new System.Drawing.Point(549, 485);
            this.traduzionek.Name = "traduzionek";
            this.traduzionek.Size = new System.Drawing.Size(118, 22);
            this.traduzionek.TabIndex = 14;
            this.traduzionek.Visible = false;
            this.traduzionek.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_2);
            // 
            // ktoroma
            // 
            this.ktoroma.Location = new System.Drawing.Point(549, 513);
            this.ktoroma.Name = "ktoroma";
            this.ktoroma.Size = new System.Drawing.Size(118, 22);
            this.ktoroma.TabIndex = 15;
            this.ktoroma.Visible = false;
            this.ktoroma.TextChanged += new System.EventHandler(this.Ktoroma_TextChanged);
            // 
            // KanaTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.ktoroma);
            this.Controls.Add(this.traduzionek);
            this.Controls.Add(this.traduzioneh);
            this.Controls.Add(this.htoroma);
            this.Controls.Add(this.NextKata);
            this.Controls.Add(this.NextHira);
            this.Controls.Add(this.CheckKata);
            this.Controls.Add(this.CheckHira);
            this.Controls.Add(this.inputkata);
            this.Controls.Add(this.Inputhira);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Outputtradkata);
            this.Controls.Add(this.OutputKata);
            this.Controls.Add(this.Outputtranshira);
            this.Controls.Add(this.OutputHira);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KanaTraining";
            this.Text = "Kana Training";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutputHira;
        private System.Windows.Forms.RichTextBox Outputtranshira;
        private System.Windows.Forms.RichTextBox OutputKata;
        private System.Windows.Forms.RichTextBox Outputtradkata;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox Inputhira;
        private System.Windows.Forms.RichTextBox inputkata;
        private System.Windows.Forms.Button CheckHira;
        private System.Windows.Forms.Button CheckKata;
        private System.Windows.Forms.Button NextHira;
        private System.Windows.Forms.Button NextKata;
        private System.Windows.Forms.TextBox htoroma;
        private System.Windows.Forms.TextBox traduzioneh;
        private System.Windows.Forms.TextBox traduzionek;
        private System.Windows.Forms.TextBox ktoroma;
    }
}

