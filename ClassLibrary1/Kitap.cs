using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Kitap : Base
    {
        public string kitapAdi {  get; set; }
        public string yazar {  get; set; }
        public string kategori { get; set; }
        public int cilt { get; set; }
        public int basimYili { get; set; }
        public string yayinEvi { get; set; }
        public int stok { get; set; }
        public bool oduncDurum { get; set; }
        public string OduncAlanAd { get; set; }
        public string OduncAlanSoyad { get; set; }
        public DateTime OduncAlmaTarihi { get; set; }
        public static bool kitapAra(object aranan)
        {
            foreach (var uye in KitapEkle.kitapList)
            {

                if (uye.kitapAdi == aranan)
                {
                    return true;
                }

            }
            return false;
        }
        public void OduncAl()
        {
            if (stok > 0)
            {
                stok--;
                
                oduncDurum = true;
            }
            
        }

        public void KitapIadeEt()
        {
            if (oduncDurum)
            {
                stok++;
                oduncDurum = true;
               
            }
            
        }

    }

}
