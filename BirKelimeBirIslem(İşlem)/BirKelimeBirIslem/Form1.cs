using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BirKelimeBirIslem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();

        public void RandomSayiUret()
        {
            int[] rakam = new int[5];
            for(int i = 0; i < rakam.Length; i++)
            {
                rakam[i]=rastgele.Next(1,10);
            }
            txtSayi1.Text = rakam[0].ToString();
            txtSayi2.Text = rakam[1].ToString();
            txtSayi3.Text = rakam[2].ToString();
            txtSayi4.Text = rakam[3].ToString();
            txtSayi5.Text = rakam[4].ToString();

            int[] onKatlari = {10,20,30,40,50,60,70,80,90};
            txtKatsayi.Text = onKatlari[rastgele.Next(9)].ToString();
            int hedefSayi;
            hedefSayi = rastgele.Next(100, 1000);
            txtHedefSayi.Text = hedefSayi.ToString();

        }
        public void Hesapla()
        {

            int hedefSayi = Convert.ToInt32(txtHedefSayi.Text);

            int[] sayilar = new int[] { Convert.ToInt32(txtSayi1.Text), 
                Convert.ToInt32(txtSayi3.Text), Convert.ToInt32(txtSayi3.Text), 
                Convert.ToInt32(txtSayi4.Text), Convert.ToInt32(txtSayi5.Text), 
                Convert.ToInt32(txtKatsayi.Text) };

            while (true)
            {
                int sayi = rastgele.Next(6);
                int temp = sayilar[sayi];
                sayilar[sayi] = sayilar[0];
                sayilar[0] = temp;

                int toplam = sayilar[0];
                string yapilanIslem = sayilar[0].ToString();

                int sayac = rastgele.Next(1, 7);

                for (int i = 1; i < sayac; i++)
                {
                    int islem = rastgele.Next(4);

                    if (islem == 0)
                    {
                        toplam += sayilar[i];
                        yapilanIslem += " + " + sayilar[i].ToString();
                    }
                    if (islem == 1)
                    {
                        toplam -= sayilar[i];
                        yapilanIslem += " - " + sayilar[i].ToString();
                    }
                    if (islem == 2)
                    {
                        toplam *= sayilar[i];
                        yapilanIslem += " x " + sayilar[i].ToString();
                    }
                    if (islem == 3)
                    {
                        if (toplam % sayilar[i] != 0) continue;
                        toplam /= sayilar[i];
                        yapilanIslem += " / " + sayilar[i].ToString();
                    }
                }
                int sonuc = toplam;

                if (toplam == hedefSayi)
                {
                    txtIslem.Text = yapilanIslem;
                    txtSonuc.Text = sonuc.ToString();
                    break;
                }
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRastgele_Click(object sender, EventArgs e)
        {
            RandomSayiUret();



        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSayi1.Clear();
            txtSayi2.Clear();
            txtSayi3.Clear();
            txtSayi4.Clear();
            txtSayi5.Clear();
            txtHedefSayi.Clear();
            txtSonuc.Clear();
            txtKatsayi.Clear();
            txtIslem.Clear();
        }
    }
}
