namespace EFUygulamaSınavıGrup3
{
    partial class YoneticiGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiGiris));
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGirisYap = new Button();
            label1 = new Label();
            label2 = new Label();
            llblKayitOl = new LinkLabel();
            label3 = new Label();
            pbSifre = new PictureBox();
            lblHataMesaji = new Label();
            label4 = new Label();
            ımageList1 = new ImageList(components);
            btnExit = new Button();
            ımageList2 = new ImageList(components);
            ımageList3 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pbSifre).BeginInit();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(150, 194);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(193, 26);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(150, 243);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(193, 26);
            txtSifre.TabIndex = 0;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.PaleGreen;
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnGirisYap.ForeColor = Color.LimeGreen;
            btnGirisYap.ImageAlign = ContentAlignment.MiddleRight;
            btnGirisYap.ImageKey = "icons8-login-32.png";
            btnGirisYap.ImageList = ımageList3;
            btnGirisYap.Location = new Point(222, 306);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(121, 38);
            btnGirisYap.TabIndex = 1;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.TextAlign = ContentAlignment.MiddleLeft;
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 197);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 246);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            // 
            // llblKayitOl
            // 
            llblKayitOl.AutoSize = true;
            llblKayitOl.Location = new Point(239, 137);
            llblKayitOl.Name = "llblKayitOl";
            llblKayitOl.Size = new Size(63, 19);
            llblKayitOl.TabIndex = 3;
            llblKayitOl.TabStop = true;
            llblKayitOl.Text = "Kayıt Ol..";
            llblKayitOl.LinkClicked += llblKayitOl_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 137);
            label3.Name = "label3";
            label3.Size = new Size(157, 19);
            label3.TabIndex = 4;
            label3.Text = "Henüz kaydınız yok mu?";
            // 
            // pbSifre
            // 
            pbSifre.Image = Properties.Resources.hidepswd;
            pbSifre.Location = new Point(350, 242);
            pbSifre.Name = "pbSifre";
            pbSifre.Size = new Size(32, 27);
            pbSifre.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSifre.TabIndex = 13;
            pbSifre.TabStop = false;
            pbSifre.MouseEnter += pbSifre_MouseEnter;
            pbSifre.MouseLeave += pbSifre_MouseLeave;
            // 
            // lblHataMesaji
            // 
            lblHataMesaji.BorderStyle = BorderStyle.FixedSingle;
            lblHataMesaji.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHataMesaji.ForeColor = Color.Red;
            lblHataMesaji.Location = new Point(55, 371);
            lblHataMesaji.Name = "lblHataMesaji";
            lblHataMesaji.Size = new Size(307, 72);
            lblHataMesaji.TabIndex = 12;
            lblHataMesaji.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.ImageKey = "icons8-login-100.png";
            label4.ImageList = ımageList1;
            label4.Location = new Point(3, 20);
            label4.Name = "label4";
            label4.Size = new Size(299, 81);
            label4.TabIndex = 14;
            label4.Text = "GİRİŞ SAYFASI";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-login-100.png");
            // 
            // btnExit
            // 
            btnExit.ImageKey = "icons8-exit-32.png";
            btnExit.ImageList = ımageList2;
            btnExit.Location = new Point(376, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(37, 35);
            btnExit.TabIndex = 15;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "icons8-exit-32.png");
            // 
            // ımageList3
            // 
            ımageList3.ColorDepth = ColorDepth.Depth32Bit;
            ımageList3.ImageStream = (ImageListStreamer)resources.GetObject("ımageList3.ImageStream");
            ımageList3.TransparentColor = Color.Transparent;
            ımageList3.Images.SetKeyName(0, "icons8-login-32.png");
            // 
            // YoneticiGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 457);
            Controls.Add(btnExit);
            Controls.Add(label4);
            Controls.Add(pbSifre);
            Controls.Add(lblHataMesaji);
            Controls.Add(label3);
            Controls.Add(llblKayitOl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "YoneticiGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoneticiGiris";
            ((System.ComponentModel.ISupportInitialize)pbSifre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGirisYap;
        private Label label1;
        private Label label2;
        private LinkLabel llblKayitOl;
        private Label label3;
        private PictureBox pbSifre;
        private Label lblHataMesaji;
        private Label label4;
        private ImageList ımageList1;
        private Button btnExit;
        private ImageList ımageList2;
        private ImageList ımageList3;
    }
}