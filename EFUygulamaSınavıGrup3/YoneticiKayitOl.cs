using EFUygulamaSınavıGrup3.Context;
using EFUygulamaSınavıGrup3.Entities;
using EFUygulamaSınavıGrup3.Properties;
using EFUygulamaSınavıGrup3.StaticMethods;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFUygulamaSınavıGrup3
{
    public partial class YoneticiKayitOl : Form
    {
        AlbumDbContext context = new AlbumDbContext();
        public YoneticiKayitOl()
        {
            InitializeComponent();

        }
        int tiklamaSayisi = 0;
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            pbSifre.Image = Resources.hidepswd;
        }

        private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            txtSifreTekrar.UseSystemPasswordChar = true;
            pbSifreTekrar.Image = Resources.hidepswd;
        }
        private void pbSifre_MouseEnter(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = false;
            pbSifre.Image = Resources.showpswd;
        }

        private void pbSifre_MouseLeave(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            pbSifre.Image = Resources.hidepswd;
        }
        private void pbSifreTekrar_MouseEnter(object sender, EventArgs e)
        {
            txtSifreTekrar.UseSystemPasswordChar = false;
            pbSifreTekrar.Image = Resources.showpswd;
        }

        private void pbSifreTekrar_MouseLeave(object sender, EventArgs e)
        {
            txtSifreTekrar.UseSystemPasswordChar = true;
            pbSifreTekrar.Image = Resources.hidepswd;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {

            var kullaniciAdi = txtKullaniciAdi.Text;
            var sifre = txtSifre.Text;
            var sifreTekrari = txtSifreTekrar.Text;

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre) || string.IsNullOrWhiteSpace(sifreTekrari))
            {
                lblHataMesaji.Text = "Kullanıcı adı veya şifre boş olamaz.";
                return;
            }

            if (sifre != sifreTekrari)
            {
                lblHataMesaji.Text = "Şifreler eşleşmiyor.";
                return;
            }

            var kullaniciKontrol = context.Yoneticiler.FirstOrDefault(u => u.KullaniciAdi == kullaniciAdi);
            if (kullaniciKontrol != null)
            {
                lblHataMesaji.Text = "Bu kullanıcı adı zaten kullanılıyor.";
                return;
            }

            if (sifre == sifreTekrari && SifreyiKontrolEt(sifre))
            {
                string sifrelenmis = Sha256Hasher.Compute256Hash(sifre);
                Yonetici yonetici = new Yonetici();
                yonetici.KullaniciAdi = kullaniciAdi;
                yonetici.Sifre = sifrelenmis;

                context.Yoneticiler.Add(yonetici);
                context.SaveChanges();
                MessageBox.Show("KAYIT BAŞARILI!");
                this.Hide();
            }


            bool SifreyiKontrolEt(string password) // şifre gereksinimlerini kontrol eder.
            {
                if (password.Length < 8)
                {
                    lblHataMesaji.Text = string.Empty;
                    lblHataMesaji.Text = "Şifre 8 karakterden uzun olmalıdır.";
                    return false;
                }
                if (password.Count(char.IsUpper) < 2)
                {
                    lblHataMesaji.Text = string.Empty;
                    lblHataMesaji.Text = "Şifre en az 2 büyük harf içermelidir.";
                    return false;
                }
                if (password.Count(char.IsLower) < 3)
                {
                    lblHataMesaji.Text = string.Empty;
                    lblHataMesaji.Text = "Şifre en az 3 küçük harf içermelidir.";
                    return false;
                }

                var ozelKarakterler = new[] { '!', ':', '+', '*' };
                int ozelKarakterSayisi = password.Count(c => ozelKarakterler.Contains(c));
                if (ozelKarakterSayisi < 2)
                {
                    lblHataMesaji.Text = string.Empty;
                    lblHataMesaji.Text = "Şifre en az 2 adet özel karakter\n('!', ':', '+', '*') içermelidir.\n (Aynı karakterden birden fazla olabilir)";
                    return false;
                }
                return true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
