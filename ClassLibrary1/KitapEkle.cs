using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class KitapEkle : Kitap
    {
        Admin admin = new Admin();
        static public List<Kitap> kitapList = new List<Kitap>();

        public override string Mesaj()
        {
            return "Merhaba " + admin.adminad;
        }
        public static void ekle(string kitapAdi, string yazar, string kategori, int cilt, int basimYili, string yayinEvi, int stok)
        {
            
            Kitap kitaplar = new Kitap();
            kitaplar.kitapAdi = kitapAdi;
            kitaplar.yazar = yazar;
            kitaplar.kategori = kategori;
            kitaplar.cilt = cilt;
            kitaplar.basimYili = basimYili;
            kitaplar.yayinEvi = yayinEvi;
            kitaplar.stok = stok;
            kitapList.Add(kitaplar);
            
        }
    }
}
