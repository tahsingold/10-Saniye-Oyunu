namespace _10_Saniye_Oyunu
{
    partial class oynaForm
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
            this.components = new System.ComponentModel.Container();
            this.zamanLabel = new System.Windows.Forms.Label();
            this.zamanDurdurButton = new System.Windows.Forms.Button();
            this.kapanisTimer = new System.Windows.Forms.Timer(this.components);
            this.sayacTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // zamanLabel
            // 
            this.zamanLabel.AutoSize = true;
            this.zamanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zamanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.zamanLabel.Location = new System.Drawing.Point(314, 95);
            this.zamanLabel.Name = "zamanLabel";
            this.zamanLabel.Size = new System.Drawing.Size(146, 69);
            this.zamanLabel.TabIndex = 0;
            this.zamanLabel.Text = "süre";
            // 
            // zamanDurdurButton
            // 
            this.zamanDurdurButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zamanDurdurButton.Location = new System.Drawing.Point(177, 236);
            this.zamanDurdurButton.Name = "zamanDurdurButton";
            this.zamanDurdurButton.Size = new System.Drawing.Size(434, 156);
            this.zamanDurdurButton.TabIndex = 1;
            this.zamanDurdurButton.Text = "Zamanı Durdur";
            this.zamanDurdurButton.UseVisualStyleBackColor = true;
            this.zamanDurdurButton.Click += new System.EventHandler(this.zamanDurdurButton_Click);
            // 
            // kapanisTimer
            // 
            this.kapanisTimer.Tick += new System.EventHandler(this.kapanisTimer_Tick);
            // 
            // sayacTimer
            // 
            this.sayacTimer.Tick += new System.EventHandler(this.sayacTimer_Tick);
            // 
            // oynaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zamanDurdurButton);
            this.Controls.Add(this.zamanLabel);
            this.Name = "oynaForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button zamanDurdurButton;
        public System.Windows.Forms.Label zamanLabel;
        private System.Windows.Forms.Timer kapanisTimer;
        public System.Windows.Forms.Timer sayacTimer;
    }
}