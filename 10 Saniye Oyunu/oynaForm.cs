using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Saniye_Oyunu
{
    public partial class oynaForm : Form
    {
        int kapanisZaman;
        public int sayacZaman;
        public oynaForm()
        {
            InitializeComponent();
            kapanisTimer.Interval = 1000;
            sayacTimer.Interval = 10;

        }

        private void zamanDurdurButton_Click(object sender, EventArgs e)
        {
            sayacTimer.Stop();
            kapanisZaman = 3;
            kapanisTimer.Start();
            zamanDurdurButton.Text = kapanisZaman.ToString();

        }

        private void kapanisTimer_Tick(object sender, EventArgs e)
        {
            
            kapanisZaman--;
            zamanDurdurButton.Text = kapanisZaman.ToString();
            if (kapanisZaman == 0)
            {
                kapanisZaman = 3;
                kapanisTimer.Stop();
                this.Close();
            }
            
        }

        private void sayacTimer_Tick(object sender, EventArgs e)
        {
            zamanDurdurButton.Text = "Zamanı Durdur";
            sayacZaman++;
            zamanLabel.Text = (sayacZaman/100.0).ToString();
        }
    }
}
