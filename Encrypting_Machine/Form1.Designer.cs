namespace Encrypting_Machine
{
    partial class DecryptoKING
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecryptoKING));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.EnterPass = new System.Windows.Forms.Label();
            this.Key = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.encryptedPass = new System.Windows.Forms.TextBox();
            this.labelOut = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.tryAgain = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Cryptoking = new System.Windows.Forms.Label();
            this.DecryptLable = new System.Windows.Forms.Label();
            this.DecrypText = new System.Windows.Forms.TextBox();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.Decryptresoultbox = new System.Windows.Forms.TextBox();
            this.Decrypttextbox = new System.Windows.Forms.Label();
            this.Decryptnew = new System.Windows.Forms.Button();
            this.DecryptKey = new System.Windows.Forms.TextBox();
            this.DecryptLablekey = new System.Windows.Forms.Label();
            this.Decryptking = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(494, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 41);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // EnterPass
            // 
            this.EnterPass.AutoSize = true;
            this.EnterPass.Location = new System.Drawing.Point(212, 116);
            this.EnterPass.Name = "EnterPass";
            this.EnterPass.Size = new System.Drawing.Size(249, 23);
            this.EnterPass.TabIndex = 2;
            this.EnterPass.Text = "Enter password to encrypt:";
            // 
            // Key
            // 
            this.Key.AutoSize = true;
            this.Key.Location = new System.Drawing.Point(212, 166);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(151, 23);
            this.Key.TabIndex = 3;
            this.Key.Text = "Enter key value:";
            // 
            // keyBox
            // 
            this.keyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.keyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyBox.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyBox.ForeColor = System.Drawing.Color.Yellow;
            this.keyBox.Location = new System.Drawing.Point(494, 164);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(100, 41);
            this.keyBox.TabIndex = 4;
            this.keyBox.TextChanged += new System.EventHandler(this.KeyBox_TextChanged);
            // 
            // encryptedPass
            // 
            this.encryptedPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.encryptedPass.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptedPass.ForeColor = System.Drawing.Color.Yellow;
            this.encryptedPass.Location = new System.Drawing.Point(494, 296);
            this.encryptedPass.Name = "encryptedPass";
            this.encryptedPass.ReadOnly = true;
            this.encryptedPass.Size = new System.Drawing.Size(170, 41);
            this.encryptedPass.TabIndex = 5;
            this.encryptedPass.TextChanged += new System.EventHandler(this.EncryptedPass_TextChanged);
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Location = new System.Drawing.Point(212, 303);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(241, 23);
            this.labelOut.TabIndex = 6;
            this.labelOut.Text = "Your encrypted password:";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Start.Location = new System.Drawing.Point(374, 223);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 38);
            this.Start.TabIndex = 7;
            this.Start.Text = "Start ";
            this.Start.UseMnemonic = false;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // tryAgain
            // 
            this.tryAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.tryAgain.Location = new System.Drawing.Point(348, 384);
            this.tryAgain.Name = "tryAgain";
            this.tryAgain.Size = new System.Drawing.Size(180, 31);
            this.tryAgain.TabIndex = 8;
            this.tryAgain.Text = "Create New";
            this.tryAgain.UseVisualStyleBackColor = false;
            this.tryAgain.Click += new System.EventHandler(this.TryAgain_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 450);
            this.panel1.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 89);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 89);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cryptoking
            // 
            this.Cryptoking.AutoSize = true;
            this.Cryptoking.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cryptoking.Location = new System.Drawing.Point(342, 9);
            this.Cryptoking.Name = "Cryptoking";
            this.Cryptoking.Size = new System.Drawing.Size(219, 34);
            this.Cryptoking.TabIndex = 4;
            this.Cryptoking.Text = "CRYPTOKING";
            // 
            // DecryptLable
            // 
            this.DecryptLable.AutoSize = true;
            this.DecryptLable.Location = new System.Drawing.Point(333, 88);
            this.DecryptLable.Name = "DecryptLable";
            this.DecryptLable.Size = new System.Drawing.Size(250, 23);
            this.DecryptLable.TabIndex = 10;
            this.DecryptLable.Text = "Enter password to decrypt:";
            // 
            // DecrypText
            // 
            this.DecrypText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.DecrypText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DecrypText.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecrypText.ForeColor = System.Drawing.Color.Yellow;
            this.DecrypText.Location = new System.Drawing.Point(337, 133);
            this.DecrypText.Name = "DecrypText";
            this.DecrypText.Size = new System.Drawing.Size(246, 41);
            this.DecrypText.TabIndex = 11;
            this.DecrypText.TextChanged += new System.EventHandler(this.DecrypText_TextChanged);
            // 
            // DecryptButton
            // 
            this.DecryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.DecryptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DecryptButton.Location = new System.Drawing.Point(408, 182);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(100, 38);
            this.DecryptButton.TabIndex = 12;
            this.DecryptButton.Text = "Start ";
            this.DecryptButton.UseMnemonic = false;
            this.DecryptButton.UseVisualStyleBackColor = false;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // Decryptresoultbox
            // 
            this.Decryptresoultbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Decryptresoultbox.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decryptresoultbox.ForeColor = System.Drawing.Color.Yellow;
            this.Decryptresoultbox.Location = new System.Drawing.Point(337, 279);
            this.Decryptresoultbox.Name = "Decryptresoultbox";
            this.Decryptresoultbox.ReadOnly = true;
            this.Decryptresoultbox.Size = new System.Drawing.Size(246, 41);
            this.Decryptresoultbox.TabIndex = 13;
            // 
            // Decrypttextbox
            // 
            this.Decrypttextbox.AutoSize = true;
            this.Decrypttextbox.Location = new System.Drawing.Point(333, 238);
            this.Decrypttextbox.Name = "Decrypttextbox";
            this.Decrypttextbox.Size = new System.Drawing.Size(242, 23);
            this.Decrypttextbox.TabIndex = 14;
            this.Decrypttextbox.Text = "Your decrypted password:";
            // 
            // Decryptnew
            // 
            this.Decryptnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Decryptnew.Location = new System.Drawing.Point(348, 384);
            this.Decryptnew.Name = "Decryptnew";
            this.Decryptnew.Size = new System.Drawing.Size(180, 31);
            this.Decryptnew.TabIndex = 15;
            this.Decryptnew.Text = "Decrypt New";
            this.Decryptnew.UseVisualStyleBackColor = false;
            this.Decryptnew.Click += new System.EventHandler(this.Decryptnew_Click_1);
            // 
            // DecryptKey
            // 
            this.DecryptKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.DecryptKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DecryptKey.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecryptKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.DecryptKey.Location = new System.Drawing.Point(512, 348);
            this.DecryptKey.Name = "DecryptKey";
            this.DecryptKey.ReadOnly = true;
            this.DecryptKey.Size = new System.Drawing.Size(100, 41);
            this.DecryptKey.TabIndex = 16;
            // 
            // DecryptLablekey
            // 
            this.DecryptLablekey.AutoSize = true;
            this.DecryptLablekey.Location = new System.Drawing.Point(333, 348);
            this.DecryptLablekey.Name = "DecryptLablekey";
            this.DecryptLablekey.Size = new System.Drawing.Size(143, 23);
            this.DecryptLablekey.TabIndex = 17;
            this.DecryptLablekey.Text = "Key value used";
            // 
            // Decryptking
            // 
            this.Decryptking.AutoSize = true;
            this.Decryptking.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decryptking.Location = new System.Drawing.Point(346, 9);
            this.Decryptking.Name = "Decryptking";
            this.Decryptking.Size = new System.Drawing.Size(237, 34);
            this.Decryptking.TabIndex = 18;
            this.Decryptking.Text = "DECRYPTKING";
            // 
            // DecryptoKING
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Decryptking);
            this.Controls.Add(this.Cryptoking);
            this.Controls.Add(this.DecryptLablekey);
            this.Controls.Add(this.DecryptKey);
            this.Controls.Add(this.Decryptnew);
            this.Controls.Add(this.Decrypttextbox);
            this.Controls.Add(this.Decryptresoultbox);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.DecrypText);
            this.Controls.Add(this.DecryptLable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tryAgain);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.encryptedPass);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.EnterPass);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DecryptoKING";
            this.Text = "DecryptoKing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label EnterPass;
        private System.Windows.Forms.Label Key;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.TextBox encryptedPass;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button tryAgain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Cryptoking;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label DecryptLable;
        private System.Windows.Forms.TextBox DecrypText;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox Decryptresoultbox;
        private System.Windows.Forms.Label Decrypttextbox;
        private System.Windows.Forms.Button Decryptnew;
        private System.Windows.Forms.TextBox DecryptKey;
        private System.Windows.Forms.Label DecryptLablekey;
        private System.Windows.Forms.Label Decryptking;
    }
}

