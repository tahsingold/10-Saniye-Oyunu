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
            this.turnuvaBaslatButton = new System.Windows.Forms.Button();
            this.katilimciListbox = new System.Windows.Forms.ListBox();
            this.denemeHakkiTextbox = new System.Windows.Forms.TextBox();
            this.oynaButton = new System.Windows.Forms.Button();
            this.yarismaciAdTextbox = new System.Windows.Forms.TextBox();
            this.yarismaciAdLabel = new System.Windows.Forms.Label();
            this.baslatUyarıLabel = new System.Windows.Forms.Label();
            this.denemeHakkiLabel = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // turnuvaBaslatButton
            // 
            this.turnuvaBaslatButton.Location = new System.Drawing.Point(91, 30);
            this.turnuvaBaslatButton.Name = "turnuvaBaslatButton";
            this.turnuvaBaslatButton.Size = new System.Drawing.Size(149, 63);
            this.turnuvaBaslatButton.TabIndex = 0;
            this.turnuvaBaslatButton.Text = "Yeni Turnuva Başlat";
            this.turnuvaBaslatButton.UseVisualStyleBackColor = true;
            this.turnuvaBaslatButton.Click += new System.EventHandler(this.turnuvaBaslatButton_Click);
            // 
            // katilimciListbox
            // 
            this.katilimciListbox.FormattingEnabled = true;
            this.katilimciListbox.ItemHeight = 16;
            this.katilimciListbox.Location = new System.Drawing.Point(479, 12);
            this.katilimciListbox.Name = "katilimciListbox";
            this.katilimciListbox.Size = new System.Drawing.Size(309, 340);
            this.katilimciListbox.TabIndex = 1;
            this.katilimciListbox.DoubleClick += new System.EventHandler(this.KatilimciListbox_DoubleClick);
            // 
            // denemeHakkiTextbox
            // 
            this.denemeHakkiTextbox.Location = new System.Drawing.Point(246, 56);
            this.denemeHakkiTextbox.Name = "denemeHakkiTextbox";
            this.denemeHakkiTextbox.Size = new System.Drawing.Size(131, 22);
            this.denemeHakkiTextbox.TabIndex = 3;
            // 
            // oynaButton
            // 
            this.oynaButton.Location = new System.Drawing.Point(91, 222);
            this.oynaButton.Name = "oynaButton";
            this.oynaButton.Size = new System.Drawing.Size(237, 63);
            this.oynaButton.TabIndex = 4;
            this.oynaButton.Text = "Başlat";
            this.oynaButton.UseVisualStyleBackColor = true;
            this.oynaButton.Click += new System.EventHandler(this.oynaButton_Click);
            // 
            // yarismaciAdTextbox
            // 
            this.yarismaciAdTextbox.Location = new System.Drawing.Point(197, 180);
            this.yarismaciAdTextbox.Name = "yarismaciAdTextbox";
            this.yarismaciAdTextbox.Size = new System.Drawing.Size(131, 22);
            this.yarismaciAdTextbox.TabIndex = 6;
            this.yarismaciAdTextbox.TextChanged += new System.EventHandler(this.yarismaciAdTextbox_TextChanged);
            // 
            // yarismaciAdLabel
            // 
            this.yarismaciAdLabel.AutoSize = true;
            this.yarismaciAdLabel.Location = new System.Drawing.Point(88, 183);
            this.yarismaciAdLabel.Name = "yarismaciAdLabel";
            this.yarismaciAdLabel.Size = new System.Drawing.Size(96, 16);
            this.yarismaciAdLabel.TabIndex = 5;
            this.yarismaciAdLabel.Text = "Yarışmacı Adı: ";
            // 
            // baslatUyarıLabel
            // 
            this.baslatUyarıLabel.AutoSize = true;
            this.baslatUyarıLabel.Location = new System.Drawing.Point(88, 288);
            this.baslatUyarıLabel.Name = "baslatUyarıLabel";
            this.baslatUyarıLabel.Size = new System.Drawing.Size(42, 16);
            this.baslatUyarıLabel.TabIndex = 7;
            this.baslatUyarıLabel.Text = "Uyarı!";
            // 
            // denemeHakkiLabel
            // 
            this.denemeHakkiLabel.AutoSize = true;
            this.denemeHakkiLabel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.denemeHakkiLabel.Location = new System.Drawing.Point(246, 30);
            this.denemeHakkiLabel.Name = "denemeHakkiLabel";
            this.denemeHakkiLabel.Size = new System.Drawing.Size(125, 20);
            this.denemeHakkiLabel.TabIndex = 8;
            this.denemeHakkiLabel.Text = "Deneme Hakkı: ";
            this.denemeHakkiLabel.UseVisualStyleBackColor = true;
            this.denemeHakkiLabel.CheckedChanged += new System.EventHandler(this.denemeHakkiLabel_CheckedChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.denemeHakkiLabel);
            this.Controls.Add(this.baslatUyarıLabel);
            this.Controls.Add(this.yarismaciAdTextbox);
            this.Controls.Add(this.yarismaciAdLabel);
            this.Controls.Add(this.oynaButton);
            this.Controls.Add(this.denemeHakkiTextbox);
            this.Controls.Add(this.katilimciListbox);
            this.Controls.Add(this.turnuvaBaslatButton);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button turnuvaBaslatButton;
        private System.Windows.Forms.ListBox katilimciListbox;
        private System.Windows.Forms.TextBox denemeHakkiTextbox;
        private System.Windows.Forms.Button oynaButton;
        private System.Windows.Forms.TextBox yarismaciAdTextbox;
        private System.Windows.Forms.Label yarismaciAdLabel;
        private System.Windows.Forms.Label baslatUyarıLabel;
        private System.Windows.Forms.CheckBox denemeHakkiLabel;
    }
}

