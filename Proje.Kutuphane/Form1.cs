using ClassLibrary1;
using System.Security.Cryptography.X509Certificates;

namespace Proje.Kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Admin admin = new Admin();
        KitapEkle kitaplar = new KitapEkle();
        Oduncler oduncler = new Oduncler();
        private void button1_Click(object sender, EventArgs e)
        {
            string kitapAdi = textBox1.Text;
            string yazar = textBox2.Text;
            string kategori = textBox3.Text;
            int cilt = Convert.ToInt32(textBox4.Text);
            int basimYili = Convert.ToInt32(textBox5.Text);
            string yayinEvi = textBox6.Text;
            int stok = Convert.ToInt32(textBox7.Text);

            KitapEkle.ekle(kitapAdi, yazar, kategori, cilt, basimYili, yayinEvi, stok);

            MessageBox.Show("Kitap eklendi!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var kisi = comboBox1.SelectedItem;
            string mesaj = Admin.uyeSil(kisi.ToString());
            MessageBox.Show(mesaj);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label8.Text = kitaplar.Mesaj();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            foreach (var uye in Uye.uyeList)
            {
                comboBox1.Items.Add(uye.kullaniciAdi);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var odunc in Oduncler.odunclerList)
            {
                richTextBox1.AppendText("Ödünç alanýn kullanýcý adý: " + odunc.kullaniciAdi + "\n");
                richTextBox1.AppendText("Ödünç alýnan kitap: " + odunc.kitapAdi + "\n");
                richTextBox1.AppendText("Ödünç alýnan tarih: " + odunc.OduncAlmaTarihi.ToString() + "\n");
            }
        }
    }
}