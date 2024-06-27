using EFUygulamaSınavıGrup3.Context;
using EFUygulamaSınavıGrup3.Properties;
using EFUygulamaSınavıGrup3.StaticMethods;
using Microsoft.EntityFrameworkCore;
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
    public partial class YoneticiGiris : Form
    {
        AlbumDbContext _context = new AlbumDbContext();
        public YoneticiGiris()
        {
            InitializeComponent();
        }
        private void llblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            YoneticiKayitOl kayitOl = new YoneticiKayitOl();
            kayitOl.ShowDialog();
        }
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = true;
            pbSifre.Image = Resources.hidepswd;
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
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string username = txtKullaniciAdi.Text;
            string password = txtSifre.Text;
            string sifrelenmis = Sha256Hasher.Compute256Hash(password);

            if (string.IsNullOrWhiteSpace(username))
            {
                lblHataMesaji.Text = "Kullanıcı adı boş bırakılamaz.";
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                lblHataMesaji.Text = "Şifre boş bırakılamaz.";
                return;
            }

            var yonetici = _context.Yoneticiler.FirstOrDefault(x => x.KullaniciAdi == username && x.Sifre == sifrelenmis);

            if (yonetici != null)
            {
                AnaForm anaForm = new AnaForm(_context, yonetici);
                anaForm.Show();
                this.Hide();
            }
            else
                lblHataMesaji.Text = "Kullanıcı adı veya şifre hatalı!!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
