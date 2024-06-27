namespace EFUygulamaSınavıGrup3
{
    partial class YoneticiKayitOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiKayitOl));
            label2 = new Label();
            label1 = new Label();
            btnKayitOl = new Button();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            label3 = new Label();
            txtSifreTekrar = new TextBox();
            lblHataMesaji = new Label();
            pbSifre = new PictureBox();
            pbSifreTekrar = new PictureBox();
            label4 = new Label();
            ımageList1 = new ImageList(components);
            btnExit = new Button();
            ımageList2 = new ImageList(components);
            ımageList3 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pbSifre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSifreTekrar).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 183);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 6;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 137);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 7;
            label1.Text = "Kullanıcı Adı:";
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.PaleGreen;
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnKayitOl.ForeColor = Color.DarkOliveGreen;
            btnKayitOl.ImageAlign = ContentAlignment.MiddleRight;
            btnKayitOl.ImageKey = "icons8-login-32 (1).png";
            btnKayitOl.ImageList = ımageList3;
            btnKayitOl.Location = new Point(190, 275);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(121, 38);
            btnKayitOl.TabIndex = 5;
            btnKayitOl.Text = "KAYIT OL";
            btnKayitOl.TextAlign = ContentAlignment.MiddleLeft;
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(118, 180);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(193, 26);
            txtSifre.TabIndex = 3;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(118, 134);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(193, 26);
            txtKullaniciAdi.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 229);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 9;
            label3.Text = "Şifre Tekrar:";
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(118, 226);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(193, 26);
            txtSifreTekrar.TabIndex = 8;
            txtSifreTekrar.TextChanged += txtSifreTekrar_TextChanged;
            // 
            // lblHataMesaji
            // 
            lblHataMesaji.BorderStyle = BorderStyle.FixedSingle;
            lblHataMesaji.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHataMesaji.ForeColor = Color.Red;
            lblHataMesaji.Location = new Point(12, 332);
            lblHataMesaji.Name = "lblHataMesaji";
            lblHataMesaji.Size = new Size(337, 72);
            lblHataMesaji.TabIndex = 10;
            lblHataMesaji.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbSifre
            // 
            pbSifre.Image = Properties.Resources.hidepswd;
            pbSifre.Location = new Point(317, 180);
            pbSifre.Name = "pbSifre";
            pbSifre.Size = new Size(32, 27);
            pbSifre.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSifre.TabIndex = 11;
            pbSifre.TabStop = false;
            pbSifre.MouseEnter += pbSifre_MouseEnter;
            pbSifre.MouseLeave += pbSifre_MouseLeave;
            // 
            // pbSifreTekrar
            // 
            pbSifreTekrar.Image = Properties.Resources.hidepswd;
            pbSifreTekrar.Location = new Point(317, 226);
            pbSifreTekrar.Name = "pbSifreTekrar";
            pbSifreTekrar.Size = new Size(32, 27);
            pbSifreTekrar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSifreTekrar.TabIndex = 11;
            pbSifreTekrar.TabStop = false;
            pbSifreTekrar.MouseEnter += pbSifreTekrar_MouseEnter;
            pbSifreTekrar.MouseLeave += pbSifreTekrar_MouseLeave;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.ForeColor = Color.DarkOrange;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.ImageKey = "icons8-login-100 (1).png";
            label4.ImageList = ımageList1;
            label4.Location = new Point(12, 19);
            label4.Name = "label4";
            label4.Size = new Size(243, 74);
            label4.TabIndex = 12;
            label4.Text = "KAYIT OL";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-login-100 (1).png");
            // 
            // btnExit
            // 
            btnExit.ImageKey = "icons8-exit-32.png";
            btnExit.ImageList = ımageList2;
            btnExit.Location = new Point(312, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(37, 35);
            btnExit.TabIndex = 16;
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
            ımageList3.Images.SetKeyName(0, "icons8-login-32 (1).png");
            // 
            // YoneticiKayitOl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 416);
            Controls.Add(btnExit);
            Controls.Add(label4);
            Controls.Add(pbSifreTekrar);
            Controls.Add(pbSifre);
            Controls.Add(lblHataMesaji);
            Controls.Add(label3);
            Controls.Add(txtSifreTekrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKayitOl);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "YoneticiKayitOl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoneticiKayitOl";
            ((System.ComponentModel.ISupportInitialize)pbSifre).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSifreTekrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btnKayitOl;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label3;
        private TextBox txtSifreTekrar;
        private Label lblHataMesaji;
        private PictureBox pbSifre;
        private PictureBox pbSifreTekrar;
        private Label label4;
        private ImageList ımageList1;
        private Button btnExit;
        private ImageList ımageList2;
        private ImageList ımageList3;
    }
}