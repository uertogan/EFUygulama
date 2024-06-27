using EFUygulamaSınavıGrup3.Context;
using EFUygulamaSınavıGrup3.Entities;

namespace EFUygulamaSınavıGrup3
{
    public partial class AnaForm : Form
    {
        private readonly AlbumDbContext _albumDbContext;
        private readonly Yonetici _yonetici;
        Album secilenAlbum;
        public AnaForm(AlbumDbContext albumDbContext, Yonetici yonetici)
        {
            InitializeComponent();
            _albumDbContext = albumDbContext;
            _yonetici = yonetici;
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            btnGuncelleme.Enabled = false;
            btnSilme.Enabled = false;
        }

        private void cbSatısDurumu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSatısDurumu.Checked)
            {
                cbSatısDurumu.Text = "Satışı Devam Ediyor";
            }
            else
                cbSatısDurumu.Text = "Satışı Devam Etmiyor";
        }
        string albumAdi;
        string sanatciAdi;
        DateTime cikisTarihi;
        double fiyat;
        double? indirimOrani = null;
        bool satisDurumu;

        private void btnEkleme_Click(object sender, EventArgs e)
        {
            if (AlbumBilgileriKontrolEt())
            {
                string albumAdi = txtAlbumAdi.Text;
                string sanatciAdi = txtSanatciAdi.Text;
                DateTime cikisTarihi = dtpCikisTarihi.Value;
                double fiyat; // fiyatın double türüne dönüşebildiğini kontrol ettikten sonra atama yapması için aşağıda tryParse kullandık.
                if (!double.TryParse(txtFiyati.Text, out fiyat))
                {
                    lblHataMesaji.Text = "Geçerli bir fiyat giriniz.";
                    return;
                }
                if (fiyat <= 0) // fiyat 0 dan büyük olmalı
                {
                    lblHataMesaji.Text = "Fiyat 0'dan büyük olmalıdır.";
                    return;
                }
                double? indirimOrani = null; // eğer indirim oranı varsa tür dönüştürme işlemini denemesi için tryParse kullandık.
                if (!string.IsNullOrEmpty(txtIndirimOrani.Text))
                {
                    double discountValue;
                    if (!double.TryParse(txtIndirimOrani.Text, out discountValue))
                    {
                        lblHataMesaji.Text = "Geçerli bir indirim oranı giriniz.";
                        return;
                    }

                    indirimOrani = discountValue;

                    if (indirimOrani <= 0) // indirim oranı 0 dan büyük olmalı (varsa)
                    {
                        lblHataMesaji.Text = "İndirim oranı 0'dan büyük olmalıdır.";
                        return;
                    }
                }

                bool satisDurumu = cbSatısDurumu.Checked;
                var newAlbum = new Album
                {
                    Ad = albumAdi,
                    Artist = sanatciAdi,
                    CikisTarihi = cikisTarihi,
                    Fiyat = fiyat,
                    IndirimOrani = indirimOrani,
                    Durumu = satisDurumu,
                    YoneticiId = _yonetici.Id,
                };

                _albumDbContext.Albumler.Add(newAlbum);
                _albumDbContext.SaveChanges();
                AlbumleriListele();
                KontrolleriSil();
                MessageBox.Show($"{newAlbum.Ad} adlı albüm başarıyla eklenmiştir.");
            }


        }
        /// <summary>
        /// Albüm adını, Sanatçı Adını, fiyatını ve çıkış tarihinin boş durumda olmamasını kontrol eder.
        /// </summary>
        /// <returns></returns>
        private bool AlbumBilgileriKontrolEt()
        {
            string albumAdi = txtAlbumAdi.Text;
            string sanatciAdi = txtSanatciAdi.Text;
            DateTime cikisTarihi = dtpCikisTarihi.Value;
            bool satisDurumu = cbSatısDurumu.Checked;

            if (string.IsNullOrWhiteSpace(albumAdi) ||
                string.IsNullOrWhiteSpace(sanatciAdi) ||
                string.IsNullOrWhiteSpace(txtFiyati.Text) ||
                string.IsNullOrWhiteSpace(dtpCikisTarihi.Text))
            {
                lblHataMesaji.Text = "Albüm adı, sanatçı adı, fiyatı ve çıkış tarihi boş olamaz!";
                return false;
            }
            return true;
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            if (secilenAlbum != null && AlbumBilgileriKontrolEt())
            {
                string albumAdi = txtAlbumAdi.Text;
                string sanatciAdi = txtSanatciAdi.Text;
                DateTime cikisTarihi = dtpCikisTarihi.Value;
                double fiyat;
                if (!double.TryParse(txtFiyati.Text, out fiyat))
                {
                    lblHataMesaji.Text = "Geçerli bir fiyat giriniz.";
                    return;
                }
                double? indirimOrani = null;
                if (!string.IsNullOrEmpty(txtIndirimOrani.Text))
                {
                    double discountValue;
                    if (!double.TryParse(txtIndirimOrani.Text, out discountValue))
                    {
                        lblHataMesaji.Text = "Geçerli bir indirim oranı giriniz.";
                        return;
                    }
                    indirimOrani = discountValue;
                }
                bool satisDurumu = cbSatısDurumu.Checked;

                secilenAlbum.Ad = albumAdi;
                secilenAlbum.Artist = sanatciAdi;
                secilenAlbum.CikisTarihi = cikisTarihi;
                secilenAlbum.Fiyat = fiyat;
                secilenAlbum.IndirimOrani = indirimOrani;
                secilenAlbum.Durumu = satisDurumu;

                _albumDbContext.SaveChanges();
                MessageBox.Show($"{secilenAlbum.Ad} adlı albüm başarıyla güncellenmiştir.");
                AlbumleriListele();
                KontrolleriSil();
            }
        }
        /// <summary>
        /// Ekleme, silme ve güncelleme işlemlerinden sonra ekrandaki kontrolleri temizler.
        /// </summary>
        private void KontrolleriSil()
        {
            txtAlbumAdi.Text = "";
            txtSanatciAdi.Text = "";
            txtFiyati.Text = "";
            txtIndirimOrani.Text = "";
            cbSatısDurumu.Checked = false;
            dtpCikisTarihi.Value = DateTime.Now;
        }
        /// <summary>
        /// Tüm albümleri listeler
        /// </summary>
        private void AlbumleriListele()
        {
            dgvListeler.DataSource = _albumDbContext.Albumler.ToList();
        }

        private void dgvListeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenAlbum = (Album)dgvListeler.SelectedRows[0].DataBoundItem;
            btnGuncelleme.Enabled = true;
            btnSilme.Enabled = true;

            txtAlbumAdi.Text = secilenAlbum.Ad;
            txtSanatciAdi.Text = secilenAlbum.Artist;
            dtpCikisTarihi.Value = secilenAlbum.CikisTarihi;
            txtFiyati.Text = secilenAlbum.Fiyat.ToString();
            txtIndirimOrani.Text = secilenAlbum?.IndirimOrani.ToString();

            if (secilenAlbum.Durumu == true)
                cbSatısDurumu.Checked = true;
            else
                cbSatısDurumu.Checked = false;
        }

        private void btnAlbumler_Click(object sender, EventArgs e)
        {
            dgvListeler.DataSource = null;
            AlbumleriListele();
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            if (secilenAlbum != null)
            {
                _albumDbContext.Albumler.Remove(secilenAlbum);
                _albumDbContext.SaveChanges();
                MessageBox.Show($"{secilenAlbum.Ad} adlı albüm başarıyla silinmiştir.");
                AlbumleriListele();
                KontrolleriSil();
            }
        }

        private void btnSatisiDurmuslar_Click(object sender, EventArgs e)
        {
            dgvListeler.DataSource = null;

            var satisiDurmusAlbumler = _albumDbContext.Albumler.Where(a => a.Durumu == false).Select(a => new
            {
                AlbumAdi = a.Ad,
                Artisti = a.Artist
            }).ToList();

            dgvListeler.DataSource = satisiDurmusAlbumler;
        }

        private void btnSatisiDevamEdenler_Click(object sender, EventArgs e)
        {
            dgvListeler.DataSource = null;

            var satisiDevamEdenler = _albumDbContext.Albumler.Where(a => a.Durumu == true).Select(a => new
            {
                AlbumAdi = a.Ad,
                Artisti = a.Artist
            }).ToList();

            dgvListeler.DataSource = satisiDevamEdenler;
        }

        private void btnEnSonEklenen10Album_Click(object sender, EventArgs e)
        {
            dgvListeler.DataSource = null;

            var enSonEklenen10 = _albumDbContext.Albumler.OrderByDescending(a => a.Id).Take(10).Select(a => new
            {
                AlbumAdi = a.Ad,
                Artisti = a.Artist
            }).ToList();

            dgvListeler.DataSource = enSonEklenen10;
        }

        private void btnIndirimdekiler_Click(object sender, EventArgs e)
        {
            dgvListeler.DataSource = null;

            var indirimdekiler = _albumDbContext.Albumler.Where(a => a.IndirimOrani != null)
                .OrderByDescending(a => a.IndirimOrani).Select(a => new
                {
                    AlbumAdi = a.Ad,
                    Artisti = a.Artist,
                    IndirimOranı = a.IndirimOrani

                }).ToList();

            dgvListeler.DataSource = indirimdekiler;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
