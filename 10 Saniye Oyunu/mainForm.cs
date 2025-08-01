using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10_Saniye_Oyunu
{
    public partial class mainForm : Form
    {
        oynaForm oynaForm = new oynaForm();
        private List<KatilimciSonuc> katilimciSonuclar = new List<KatilimciSonuc>();
        bool turnuvaBaslatildi = false;
        int denemeSayisi = 0;
        int denemeHakki = 0;

        public mainForm()
        {
            InitializeComponent();

            baslatUyarıLabel.ForeColor = Color.Red;
            baslatUyarıLabel.Text = "";

            yarismaciAdTextbox.Text = "";
            turnuvaBaslatButton.Text = "Yeni Turnuva Başlat";
            yarismaciAdTextbox.Enabled = false;
            oynaButton.Enabled = false;
            denemeHakkiLabel.Checked = false;
            katilimciListbox.Enabled = false;

            denemeHakkiTextbox.Text = "1";
            denemeHakkiTextbox.Enabled = false;
            denemeHakkiTextbox.Visible = false;


        }

        private void KatilimciListbox_DoubleClick(object sender, EventArgs e)
        {
            if (katilimciListbox.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz yarışmacıyı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Seçili yarışmacıyı silmek istediğinize emin misiniz?", "Yarışmacı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
                return;

            // Seçili itemdan ismi ayıkla
            string secili = katilimciListbox.SelectedItem.ToString();
            // Format: "zaman - isim"
            int tireIndex = secili.IndexOf('-');
            if (tireIndex < 0) return;
            string ad = secili.Substring(tireIndex + 1).Trim();

            // Listeden sil
            var silinecek = katilimciSonuclar.FirstOrDefault(k => k.Ad.Equals(ad, StringComparison.OrdinalIgnoreCase));
            if (silinecek != null)
            {
                katilimciSonuclar.Remove(silinecek);
                ListeyiGuncelle();
            }
        }

        private void ListeyiGuncelle()
        {
            var sorted = katilimciSonuclar
                .OrderBy(k => Math.Abs(k.ZamanMs - 10000))
                .ToList();

            katilimciListbox.Items.Clear();
            foreach (var k in sorted)
            {
                katilimciListbox.Items.Add($"{k.ZamanMs / 100.0} - {k.Ad}");
            }
        }

        private void turnuvaBaslatButton_Click(object sender, EventArgs e)
        {
            if (turnuvaBaslatildi == false)
            {
                if (string.IsNullOrEmpty(denemeHakkiTextbox.Text) || !int.TryParse(denemeHakkiTextbox.Text, out int deneme) || deneme <= 0)
                {
                    MessageBox.Show("Lütfen geçerli bir deneme hakkı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                denemeHakki = deneme;

                yarismaciAdTextbox.Text = "";
                yarismaciAdTextbox.Enabled = true;
                denemeHakkiTextbox.Enabled = false;
                denemeHakkiLabel.Enabled = false;
                turnuvaBaslatildi = true;
                katilimciSonuclar.Clear();
                ListeyiGuncelle();
                katilimciListbox.Enabled = true;
                turnuvaBaslatButton.Text = "Turnuvayı Bitir";
                return;


            }
            if (turnuvaBaslatildi == true)
            {


                if (katilimciSonuclar.Count == 0)
                {
                    MessageBox.Show("Turnuva Bitti!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Turnuvayı bitirmek istediğinize emin misiniz?", "Turnuva Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (DialogResult.No == result)
                        return;
                }

                // Turnuvayı bitir
                turnuvaBaslatildi = false;
                denemeHakkiLabel.Checked = false;
                denemeHakkiLabel.Enabled = true;
                yarismaciAdTextbox.Enabled = false;
                oynaButton.Enabled = false;
                katilimciListbox.Enabled = false;
                denemeHakki = 0;
                turnuvaBaslatButton.Text = "Yeni Turnuva Başlat";
                // Sonuçları dışarı aktar
                if (katilimciSonuclar.Count != 0)
                {
                    DialogResult result = MessageBox.Show("Turnuva bitti. Sonuçları dışarı aktarmak istiyor musunuz?", "Turnuva Bitti", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (DialogResult.Yes == result)
                        disariAktar();
                }
                return;
            }

        }

        private void disariAktar()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Metin Dosyası|*.txt";
                sfd.Title = "Sonuçları Dışarı Aktar";
                sfd.FileName = "sonuclar.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Her satır: "Zaman - Ad"
                    var satirlar = katilimciSonuclar
                        .OrderBy(k => Math.Abs(k.ZamanMs - 10000))
                        .Select(k => $"{k.ZamanMs / 100.0} - {k.Ad}")
                        .ToList();

                    System.IO.File.WriteAllLines(sfd.FileName, satirlar, Encoding.UTF8);
                    MessageBox.Show("Sonuçlar başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void oynaButton_Click(object sender, EventArgs e)
        {
            denemeSayisi = 0;
            List<int> denemeler = new List<int>(); // Changed from ArrayList to List<int>
            this.Hide();
            while (denemeHakki > denemeSayisi)
            {

                oynaForm.sayacZaman = 0;
                oynaForm.sayacTimer.Start();
                oynaForm.ShowDialog();
                denemeSayisi++;

                denemeler.Add(oynaForm.sayacZaman);
                if (denemeHakki > denemeSayisi)
                {
                    DialogResult result = MessageBox.Show("Tekrar Deneme Hakkınız Var Kullanmak. İster misiniz?", "Tekrar Dene", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (DialogResult.No == result)
                        break;
                }

            }
            int enYakinDeger = denemeler.OrderBy(d => Math.Abs(d - 10000)).First();

            katilimciSonuclar.Add(new KatilimciSonuc(yarismaciAdTextbox.Text, enYakinDeger));
            ListeyiGuncelle();
            MessageBox.Show($"Yarışmacı Kaydedildi! {enYakinDeger / 100.0} - {yarismaciAdTextbox.Text}");
            yarismaciAdTextbox.Text = "";
            this.Show();
        }

        private void yarismaciAdTextbox_TextChanged(object sender, EventArgs e)
        {
            string girilenAd = yarismaciAdTextbox.Text.Trim();
            bool adBos = string.IsNullOrEmpty(girilenAd);
            bool adVar = katilimciSonuclar.Any(k => k.Ad.Equals(girilenAd, StringComparison.OrdinalIgnoreCase));

            if (adBos)
            {
                oynaButton.Enabled = false;
                baslatUyarıLabel.Text = "Yarışmacı Adı Boş Olmamalı!";
            }
            else if (adVar)
            {
                oynaButton.Enabled = false;
                baslatUyarıLabel.Text = "Mevcut Yarışmacı Adı Daha Önceden Kullanılmış!";
            }
            else
            {
                oynaButton.Enabled = true;
                baslatUyarıLabel.Text = "";
            }
        }

        private void denemeHakkiLabel_CheckedChanged(object sender, EventArgs e)
        {
            if (denemeHakkiLabel.Checked)
            {
                denemeHakkiTextbox.Text = "";
                denemeHakkiTextbox.Enabled = true;
                denemeHakkiTextbox.Visible = true;
            }
            if (!denemeHakkiLabel.Checked)
            {
                denemeHakkiTextbox.Text = "1";
                denemeHakkiTextbox.Enabled = false;
                denemeHakkiTextbox.Visible = false;
            }
        }
    }

    public class KatilimciSonuc
    {
        public string Ad { get; set; }
        public int ZamanMs { get; set; }

        public KatilimciSonuc(string ad, int zamanMs)
        {
            Ad = ad;
            ZamanMs = zamanMs;
        }
    }

}
