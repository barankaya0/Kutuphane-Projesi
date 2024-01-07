using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Oduncler : Kitap
    {
        public static List<Oduncler> odunclerList = new List<Oduncler>();

        public static void oduncAlinan(string aktifkullanici,DateTime oduncTarih,string kitapAdi)
        {

            Oduncler yeniOdunc = new Oduncler();
            yeniOdunc.kullaniciAdi = aktifkullanici;
            yeniOdunc.kitapAdi = kitapAdi;
            yeniOdunc.OduncAlmaTarihi = oduncTarih;
            odunclerList.Add(yeniOdunc);


        }
        
        

    }
}
