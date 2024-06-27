using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUygulamaSınavıGrup3.Entities
{
    public class Album
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Artist { get; set; }
        public DateTime CikisTarihi { get; set; }
        public double Fiyat { get; set; }
        public double? IndirimOrani { get; set; }
        public bool Durumu { get; set; }
        public int YoneticiId { get; set; }
        public Yonetici Yonetici { get; set;}
    }
}
