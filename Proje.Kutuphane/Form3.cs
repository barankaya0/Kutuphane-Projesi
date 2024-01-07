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
    public partial class Form3 : Form
    {
        private List<Kitap> kitaplar = new List<Kitap>();
        Base yeni;
        public Form3()
        {
            InitializeComponent();
        }
        public static string aktifKullanici { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            comboBox1.Items.Clear();
            

            foreach (var kitap in KitapEkle.kitapList)
            {

                comboBox1.Items.Add(kitap.kitapAdi);


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            bool durum;
            var aranan = comboBox1.SelectedItem;
            durum = Kitap.kitapAra(aranan);
            if (durum == true)
            {
                richTextBox1.Clear();

                foreach (var item in KitapEkle.kitapList)
                {
                    if (item.kitapAdi == aranan.ToString())
                    {
                        richTextBox1.AppendText("Kitap Adı: " + item.kitapAdi);
                        richTextBox1.AppendText("\nYazar: " + item.yazar);
                        richTextBox1.AppendText("\nKategori: " + item.kategori);
                        richTextBox1.AppendText("\nCilt: " + item.cilt);
                        richTextBox1.AppendText("\nBasim Tarihi: " + item.basimYili);
                        richTextBox1.AppendText("\nYazar:" + item.yazar);
                        richTextBox1.AppendText("\nYayın Evi: " + item.yayinEvi);
                        richTextBox1.AppendText("\nStok: " + item.stok);


                        break;
                    }
                }
            }
            else { MessageBox.Show("Böyle bir kitap yok!"); }


        }

        private void button4_Click(object sender, EventArgs e)
        {

            var aranan = comboBox1.SelectedItem;
            if (aranan != null)
            {
                foreach (var item in KitapEkle.kitapList)
                {
                    if (item.kitapAdi == aranan.ToString())
                    {

                        item.OduncAl();
                        MessageBox.Show(item.kitapAdi + "adlı kitap ödünç alındı.");
                        DateTime oduncTarih = DateTime.Now;
                        Oduncler.oduncAlinan(aktifKullanici, oduncTarih, item.kitapAdi);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen ödünç almak istediğiniz kitabı seçin.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var aranan = comboBox1.SelectedItem;
            if (aranan != null)
            {
                foreach (var item in KitapEkle.kitapList)
                {
                    if (item.kitapAdi == aranan.ToString())
                    {
                        item.KitapIadeEt();
                        MessageBox.Show("Kitap iade edildi!");
                        Oduncler.odunclerList.Clear();
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen iade etmek istediğiniz kitabı seçin.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
