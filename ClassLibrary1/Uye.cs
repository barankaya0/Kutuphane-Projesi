using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Uye : Base
    {

        static public List<Base> uyeList = new List<Base>();
        public static void yeniUye(string ad, string soyad, string kullaniciadi, string sifre, DateTime dogumTarihi)
        {
            Base yeniUye = new Uye();
            Guid yeniguid = new Guid();
            yeniUye.Id = yeniguid;
            yeniUye.ad = ad;
            yeniUye.soyad = soyad;
            yeniUye.kullaniciAdi = kullaniciadi;
            yeniUye.sifre = sifre;
            yeniUye.dogumTarihi = dogumTarihi;
            uyeList.Add(yeniUye);
            


        }

        public static bool uyeAra(string kullaniciad, string sifre)
        {
            foreach (var uye in uyeList)
            {
                
                if (uye.kullaniciAdi == kullaniciad && uye.sifre == sifre)
                {
                    return true; 
                }
                
            }
            return false;
            
        }

        

    }
}
