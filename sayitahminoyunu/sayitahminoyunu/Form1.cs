using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayitahminoyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tutulansayi;
        public void sayitut()
        {
            Random rnd = new Random();
            tutulansayi = rnd.Next(1, 100);
        }
        public void button1_Click(object sender, EventArgs e)
        {
            sayitut();
            label1.Text = "Aklımdan bir sayi tuttum.\n Tahminini kutuya yaz\n ve kontrol et";
            button1.Visible = false;
            button2.Visible = true;
        }
        int skor = 10;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string girilensayi = textBox1.Text;
            
            int tahmin_edilen_sayi = Convert.ToInt16(textBox1.Text);
            if (tahmin_edilen_sayi == tutulansayi)
            {
                label2.Text = "Bildin!!!";
            }
            label3.Text = skor.ToString();
            if (tahmin_edilen_sayi > tutulansayi)
            {
                label2.Text = "Tuttuğum sayı daha küçük";
                
            }
            if (tahmin_edilen_sayi != tutulansayi)
            {
                int guncellenenskor = (skor - 1);
                label3.Text = guncellenenskor.ToString();
                guncellenenskor = Convert.ToInt32(label3.Text);
                skor = guncellenenskor;
            }
            if (skor <= 0)
            {
                DialogResult result1 = new DialogResult();

                result1 = MessageBox.Show("Tekrar Deneyiniz", "Başarısız Oyun", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (result1 == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                if (result1 == DialogResult.Retry)
                {
                    button2.Visible = false;
                    label1.Text = "Yeni sayı tutuyorumm...";
                    timer1.Start();
                    button1.Visible = true;
                }
            }
            if (tahmin_edilen_sayi < tutulansayi)
            {
                label2.Text = "Tuttuğum sayı daha büyük";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 8;
            if (panel2.Width >= panel1.Width)
            {
                timer1.Stop();
                label1.Text = "Yeni Sayı Tuttum.\n" +
                    "Hemen Tahminde bulun.";
                sayitut();
                skor = 10;
                label3.Text ="Kalan Hakkınız: "+skor.ToString();
                button2.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
        }
    }
}
