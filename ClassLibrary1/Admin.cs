using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Admin : Uye
    {
        public string adminad { get; set; }
        public string adminPassword { get; set; }
        public Admin() 
        {
            adminad = "admin";
            adminPassword = "159";
        }

        public static string uyeSil(string kullaniciadi)
        {

            Base silinecekUye = uyeList.Find(u => u.kullaniciAdi == kullaniciadi);
            if (silinecekUye != null)
            {
                uyeList.Remove(silinecekUye);

                return "Üye silindi";
            }
            else
            {
                return "Böyle bir üye yok";
            }
           
        }

        
    }
}
