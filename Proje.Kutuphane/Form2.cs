using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje.Kutuphane
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        Admin admin = new Admin();
        Uye yeniUye = new Uye();

        private void button1_Click(object sender, EventArgs e)
        {
            KitapEkle.ekle("Fahrenheit 451", "Ray Bradbury", "Bilim Kurgu", 1, 2018, "İthaki Yayınları", 20);
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string kullaniciadi = textBox4.Text;
            string sifre = textBox5.Text;
            DateTime dogumTarihi = dateTimePicker1.Value;
            Uye.yeniUye(ad, soyad, kullaniciadi, sifre, dogumTarihi);
            MessageBox.Show("Kayıt başarılı!");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string kullaniciad = textBox6.Text;
            string parola = textBox3.Text;
            if (kullaniciad == "admin" && parola == admin.adminPassword)
            {
                Form1 frm = new Form1();
                this.Hide();
                frm.Show();
            }
            bool a = Uye.uyeAra(kullaniciad, parola);
            if (a == true)
            {
                Form3.aktifKullanici = kullaniciad;
                Form3 frm = new Form3();
                this.Hide();
                frm.Show();
            }
            else if (a == false && kullaniciad != "admin")
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }
    }
}
