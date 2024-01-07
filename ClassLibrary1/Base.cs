using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary1
{
    public abstract class Base
    {   
        public Guid Id { get; set; }
        public string ad {  get; set; }
        public string soyad { get; set; }
        
        public DateTime tarih { get; set; }
        public string kullaniciAdi {  get; set; }
        public string sifre {  get; set; }
        public DateTime dogumTarihi { get; set; }
        public string mesaj {  get; set; }
        public virtual string Mesaj()
        {
            mesaj = "Merhaba " + kullaniciAdi;
            return mesaj;
        }
        public Base()
        {   
            
            tarih = DateTime.Now;
        }
    }
}