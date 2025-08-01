namespace _10_Saniye_Oyunu
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.turnuvaBaslatButton = new System.Windows.Forms.Button();
            this.katilimciListbox = new System.Windows.Forms.ListBox();
            this.denemeHakkiTextbox = new System.Windows.Forms.TextBox();
            this.oynaButton = new System.Windows.Forms.Button();
            this.yarismaciAdTextbox = new System.Windows.Forms.TextBox();
            this.yarismaciAdLabel = new System.Windows.Forms.Label();
            this.baslatUyarıLabel = new System.Windows.Forms.Label();
            this.denemeHakkiLabel = new System.Windows.Forms.CheckBox();
            this.skorTahtasiLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // turnuvaBaslatButton
            // 
            this.turnuvaBaslatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.turnuvaBaslatButton.Location = new System.Drawing.Point(20, 20);
            this.turnuvaBaslatButton.Name = "turnuvaBaslatButton";
            this.turnuvaBaslatButton.Size = new System.Drawing.Size(180, 40);
            this.turnuvaBaslatButton.TabIndex = 0;
            this.turnuvaBaslatButton.Text = "Yeni Turnuva Başlat";
            this.turnuvaBaslatButton.UseVisualStyleBackColor = true;
            this.turnuvaBaslatButton.Click += new System.EventHandler(this.turnuvaBaslatButton_Click);
            // 
            // katilimciListbox
            // 
            this.katilimciListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.katilimciListbox.FormattingEnabled = true;
            this.katilimciListbox.ItemHeight = 20;
            this.katilimciListbox.Location = new System.Drawing.Point(20, 163);
            this.katilimciListbox.Name = "katilimciListbox";
            this.katilimciListbox.Size = new System.Drawing.Size(478, 304);
            this.katilimciListbox.TabIndex = 1;
            this.katilimciListbox.DoubleClick += new System.EventHandler(this.KatilimciListbox_DoubleClick);
            // 
            // denemeHakkiTextbox
            // 
            this.denemeHakkiTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.denemeHakkiTextbox.Location = new System.Drawing.Point(378, 27);
            this.denemeHakkiTextbox.Name = "denemeHakkiTextbox";
            this.denemeHakkiTextbox.Size = new System.Drawing.Size(120, 27);
            this.denemeHakkiTextbox.TabIndex = 3;
            this.denemeHakkiTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // oynaButton
            // 
            this.oynaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oynaButton.Location = new System.Drawing.Point(357, 76);
            this.oynaButton.Name = "oynaButton";
            this.oynaButton.Size = new System.Drawing.Size(141, 35);
            this.oynaButton.TabIndex = 4;
            this.oynaButton.Text = "Başlat";
            this.oynaButton.UseVisualStyleBackColor = true;
            this.oynaButton.Click += new System.EventHandler(this.oynaButton_Click);
            // 
            // yarismaciAdTextbox
            // 
            this.yarismaciAdTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yarismaciAdTextbox.Location = new System.Drawing.Point(144, 80);
            this.yarismaciAdTextbox.Name = "yarismaciAdTextbox";
            this.yarismaciAdTextbox.Size = new System.Drawing.Size(207, 27);
            this.yarismaciAdTextbox.TabIndex = 6;
            this.yarismaciAdTextbox.TextChanged += new System.EventHandler(this.yarismaciAdTextbox_TextChanged);
            // 
            // yarismaciAdLabel
            // 
            this.yarismaciAdLabel.AutoSize = true;
            this.yarismaciAdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yarismaciAdLabel.Location = new System.Drawing.Point(16, 83);
            this.yarismaciAdLabel.Name = "yarismaciAdLabel";
            this.yarismaciAdLabel.Size = new System.Drawing.Size(122, 20);
            this.yarismaciAdLabel.TabIndex = 5;
            this.yarismaciAdLabel.Text = "Yarışmacı Adı: ";
            // 
            // baslatUyarıLabel
            // 
            this.baslatUyarıLabel.AutoSize = true;
            this.baslatUyarıLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslatUyarıLabel.Location = new System.Drawing.Point(140, 110);
            this.baslatUyarıLabel.Name = "baslatUyarıLabel";
            this.baslatUyarıLabel.Size = new System.Drawing.Size(53, 20);
            this.baslatUyarıLabel.TabIndex = 7;
            this.baslatUyarıLabel.Text = "Uyarı!";
            // 
            // denemeHakkiLabel
            // 
            this.denemeHakkiLabel.AutoSize = true;
            this.denemeHakkiLabel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.denemeHakkiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.denemeHakkiLabel.Location = new System.Drawing.Point(221, 29);
            this.denemeHakkiLabel.Name = "denemeHakkiLabel";
            this.denemeHakkiLabel.Size = new System.Drawing.Size(151, 24);
            this.denemeHakkiLabel.TabIndex = 8;
            this.denemeHakkiLabel.Text = "Deneme Hakkı: ";
            this.denemeHakkiLabel.UseVisualStyleBackColor = true;
            this.denemeHakkiLabel.CheckedChanged += new System.EventHandler(this.denemeHakkiLabel_CheckedChanged);
            // 
            // skorTahtasiLabel
            // 
            this.skorTahtasiLabel.AutoSize = true;
            this.skorTahtasiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorTahtasiLabel.Location = new System.Drawing.Point(200, 140);
            this.skorTahtasiLabel.Name = "skorTahtasiLabel";
            this.skorTahtasiLabel.Size = new System.Drawing.Size(103, 20);
            this.skorTahtasiLabel.TabIndex = 9;
            this.skorTahtasiLabel.Text = "Skor Tahtası";
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(510, 481);
            this.Controls.Add(this.skorTahtasiLabel);
            this.Controls.Add(this.denemeHakkiLabel);
            this.Controls.Add(this.baslatUyarıLabel);
            this.Controls.Add(this.yarismaciAdTextbox);
            this.Controls.Add(this.yarismaciAdLabel);
            this.Controls.Add(this.oynaButton);
            this.Controls.Add(this.denemeHakkiTextbox);
            this.Controls.Add(this.katilimciListbox);
            this.Controls.Add(this.turnuvaBaslatButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "10 Saniye";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button turnuvaBaslatButton;
        private System.Windows.Forms.ListBox katilimciListbox;
        private System.Windows.Forms.TextBox denemeHakkiTextbox;
        private System.Windows.Forms.Button oynaButton;
        private System.Windows.Forms.Label yarismaciAdLabel;
        private System.Windows.Forms.Label baslatUyarıLabel;
        private System.Windows.Forms.CheckBox denemeHakkiLabel;
        public System.Windows.Forms.TextBox yarismaciAdTextbox;
        private System.Windows.Forms.Label skorTahtasiLabel;
    }
}

