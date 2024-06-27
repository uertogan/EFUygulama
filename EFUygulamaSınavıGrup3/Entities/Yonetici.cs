using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUygulamaSınavıGrup3.Entities
{
    public class Yonetici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public List<Album> Albumler { get; set; }

    }
}
