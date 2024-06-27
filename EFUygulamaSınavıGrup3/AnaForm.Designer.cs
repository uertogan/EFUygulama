namespace EFUygulamaSınavıGrup3
{
    partial class AnaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            btnEkleme = new Button();
            btnGuncelleme = new Button();
            btnSilme = new Button();
            txtAlbumAdi = new TextBox();
            txtSanatciAdi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dtpCikisTarihi = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            txtFiyati = new TextBox();
            label5 = new Label();
            txtIndirimOrani = new TextBox();
            panel1 = new Panel();
            lblHataMesaji = new Label();
            cbSatısDurumu = new CheckBox();
            label6 = new Label();
            dgvListeler = new DataGridView();
            btnAlbumler = new Button();
            btnSatisiDurmuslar = new Button();
            btnSatisiDevamEdenler = new Button();
            btnEnSonEklenen10Album = new Button();
            btnIndirimdekiler = new Button();
            btnExit = new Button();
            ımageList1 = new ImageList(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListeler).BeginInit();
            SuspendLayout();
            // 
            // btnEkleme
            // 
            btnEkleme.BackColor = Color.PaleGreen;
            btnEkleme.FlatStyle = FlatStyle.Flat;
            btnEkleme.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnEkleme.ForeColor = Color.DarkOliveGreen;
            btnEkleme.Location = new Point(42, 428);
            btnEkleme.Name = "btnEkleme";
            btnEkleme.Size = new Size(96, 64);
            btnEkleme.TabIndex = 0;
            btnEkleme.Text = "EKLEME";
            btnEkleme.UseVisualStyleBackColor = false;
            btnEkleme.Click += btnEkleme_Click;
            // 
            // btnGuncelleme
            // 
            btnGuncelleme.BackColor = Color.PowderBlue;
            btnGuncelleme.FlatStyle = FlatStyle.Flat;
            btnGuncelleme.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnGuncelleme.ForeColor = Color.DarkSlateGray;
            btnGuncelleme.Location = new Point(144, 428);
            btnGuncelleme.Name = "btnGuncelleme";
            btnGuncelleme.Size = new Size(138, 64);
            btnGuncelleme.TabIndex = 1;
            btnGuncelleme.Text = "GÜNCELLEME";
            btnGuncelleme.UseVisualStyleBackColor = false;
            btnGuncelleme.Click += btnGuncelleme_Click;
            // 
            // btnSilme
            // 
            btnSilme.BackColor = Color.Tomato;
            btnSilme.FlatStyle = FlatStyle.Flat;
            btnSilme.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnSilme.ForeColor = Color.DarkRed;
            btnSilme.Location = new Point(288, 428);
            btnSilme.Name = "btnSilme";
            btnSilme.Size = new Size(93, 64);
            btnSilme.TabIndex = 2;
            btnSilme.Text = "SİLME";
            btnSilme.UseVisualStyleBackColor = false;
            btnSilme.Click += btnSilme_Click;
            // 
            // txtAlbumAdi
            // 
            txtAlbumAdi.Location = new Point(164, 37);
            txtAlbumAdi.Name = "txtAlbumAdi";
            txtAlbumAdi.Size = new Size(200, 26);
            txtAlbumAdi.TabIndex = 3;
            // 
            // txtSanatciAdi
            // 
            txtSanatciAdi.Location = new Point(164, 89);
            txtSanatciAdi.Name = "txtSanatciAdi";
            txtSanatciAdi.Size = new Size(200, 26);
            txtSanatciAdi.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 40);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 5;
            label1.Text = "Albüm Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 92);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 6;
            label2.Text = "Sanatçı Adı:";
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(164, 141);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(200, 26);
            dtpCikisTarihi.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 145);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 8;
            label3.Text = "Çıkış Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 196);
            label4.Name = "label4";
            label4.Size = new Size(70, 19);
            label4.TabIndex = 10;
            label4.Text = "Fiyatı (TL):";
            // 
            // txtFiyati
            // 
            txtFiyati.Location = new Point(164, 193);
            txtFiyati.Name = "txtFiyati";
            txtFiyati.Size = new Size(200, 26);
            txtFiyati.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 248);
            label5.Name = "label5";
            label5.Size = new Size(138, 19);
            label5.TabIndex = 12;
            label5.Text = "İndirim Oranı (Varsa):";
            // 
            // txtIndirimOrani
            // 
            txtIndirimOrani.Location = new Point(164, 245);
            txtIndirimOrani.Name = "txtIndirimOrani";
            txtIndirimOrani.Size = new Size(200, 26);
            txtIndirimOrani.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblHataMesaji);
            panel1.Controls.Add(cbSatısDurumu);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtSanatciAdi);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnEkleme);
            panel1.Controls.Add(txtIndirimOrani);
            panel1.Controls.Add(btnGuncelleme);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSilme);
            panel1.Controls.Add(txtFiyati);
            panel1.Controls.Add(txtAlbumAdi);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpCikisTarihi);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 514);
            panel1.TabIndex = 13;
            // 
            // lblHataMesaji
            // 
            lblHataMesaji.BorderStyle = BorderStyle.FixedSingle;
            lblHataMesaji.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHataMesaji.ForeColor = Color.Red;
            lblHataMesaji.Location = new Point(54, 341);
            lblHataMesaji.Name = "lblHataMesaji";
            lblHataMesaji.Size = new Size(307, 72);
            lblHataMesaji.TabIndex = 16;
            lblHataMesaji.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbSatısDurumu
            // 
            cbSatısDurumu.AutoSize = true;
            cbSatısDurumu.Location = new Point(164, 298);
            cbSatısDurumu.Name = "cbSatısDurumu";
            cbSatısDurumu.Size = new Size(157, 23);
            cbSatısDurumu.TabIndex = 15;
            cbSatısDurumu.Text = "Satışı Devam Etmiyor";
            cbSatısDurumu.UseVisualStyleBackColor = true;
            cbSatısDurumu.CheckedChanged += cbSatısDurumu_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 298);
            label6.Name = "label6";
            label6.Size = new Size(95, 19);
            label6.TabIndex = 14;
            label6.Text = "Satış Durumu:";
            // 
            // dgvListeler
            // 
            dgvListeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListeler.Location = new Point(486, 139);
            dgvListeler.Name = "dgvListeler";
            dgvListeler.RowHeadersWidth = 51;
            dgvListeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListeler.Size = new Size(687, 387);
            dgvListeler.TabIndex = 14;
            dgvListeler.CellClick += dgvListeler_CellClick;
            // 
            // btnAlbumler
            // 
            btnAlbumler.BackColor = Color.Khaki;
            btnAlbumler.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnAlbumler.Location = new Point(486, 50);
            btnAlbumler.Name = "btnAlbumler";
            btnAlbumler.Size = new Size(100, 66);
            btnAlbumler.TabIndex = 15;
            btnAlbumler.Text = "Albümler";
            btnAlbumler.UseVisualStyleBackColor = false;
            btnAlbumler.Click += btnAlbumler_Click;
            // 
            // btnSatisiDurmuslar
            // 
            btnSatisiDurmuslar.BackColor = Color.Khaki;
            btnSatisiDurmuslar.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnSatisiDurmuslar.Location = new Point(592, 50);
            btnSatisiDurmuslar.Name = "btnSatisiDurmuslar";
            btnSatisiDurmuslar.Size = new Size(139, 64);
            btnSatisiDurmuslar.TabIndex = 16;
            btnSatisiDurmuslar.Text = "Satışı Durmuş Albümler";
            btnSatisiDurmuslar.UseVisualStyleBackColor = false;
            btnSatisiDurmuslar.Click += btnSatisiDurmuslar_Click;
            // 
            // btnSatisiDevamEdenler
            // 
            btnSatisiDevamEdenler.BackColor = Color.Khaki;
            btnSatisiDevamEdenler.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnSatisiDevamEdenler.Location = new Point(737, 50);
            btnSatisiDevamEdenler.Name = "btnSatisiDevamEdenler";
            btnSatisiDevamEdenler.Size = new Size(128, 65);
            btnSatisiDevamEdenler.TabIndex = 17;
            btnSatisiDevamEdenler.Text = "Satışı Devam Eden Albümler";
            btnSatisiDevamEdenler.UseVisualStyleBackColor = false;
            btnSatisiDevamEdenler.Click += btnSatisiDevamEdenler_Click;
            // 
            // btnEnSonEklenen10Album
            // 
            btnEnSonEklenen10Album.BackColor = Color.Khaki;
            btnEnSonEklenen10Album.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnEnSonEklenen10Album.Location = new Point(871, 50);
            btnEnSonEklenen10Album.Name = "btnEnSonEklenen10Album";
            btnEnSonEklenen10Album.Size = new Size(162, 64);
            btnEnSonEklenen10Album.TabIndex = 19;
            btnEnSonEklenen10Album.Text = "En Son Eklenen 10 Albüm";
            btnEnSonEklenen10Album.UseVisualStyleBackColor = false;
            btnEnSonEklenen10Album.Click += btnEnSonEklenen10Album_Click;
            // 
            // btnIndirimdekiler
            // 
            btnIndirimdekiler.BackColor = Color.Khaki;
            btnIndirimdekiler.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnIndirimdekiler.Location = new Point(1039, 50);
            btnIndirimdekiler.Name = "btnIndirimdekiler";
            btnIndirimdekiler.Size = new Size(134, 64);
            btnIndirimdekiler.TabIndex = 20;
            btnIndirimdekiler.Text = "İndirimdeki Albümler";
            btnIndirimdekiler.UseVisualStyleBackColor = false;
            btnIndirimdekiler.Click += btnIndirimdekiler_Click;
            // 
            // btnExit
            // 
            btnExit.ImageKey = "icons8-exit-32.png";
            btnExit.ImageList = ımageList1;
            btnExit.Location = new Point(1180, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(37, 35);
            btnExit.TabIndex = 21;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "icons8-exit-32.png");
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 538);
            Controls.Add(btnExit);
            Controls.Add(btnEnSonEklenen10Album);
            Controls.Add(btnIndirimdekiler);
            Controls.Add(btnAlbumler);
            Controls.Add(btnSatisiDurmuslar);
            Controls.Add(btnSatisiDevamEdenler);
            Controls.Add(dgvListeler);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += AnaForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListeler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEkleme;
        private Button btnGuncelleme;
        private Button btnSilme;
        private TextBox txtAlbumAdi;
        private TextBox txtSanatciAdi;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpCikisTarihi;
        private Label label3;
        private Label label4;
        private TextBox txtFiyati;
        private Label label5;
        private TextBox txtIndirimOrani;
        private Panel panel1;
        private CheckBox cbSatısDurumu;
        private Label label6;
        private Label lblHataMesaji;
        private DataGridView dgvListeler;
        private Button btnAlbumler;
        private Button btnSatisiDurmuslar;
        private Button btnSatisiDevamEdenler;
        private Button btnEnSonEklenen10Album;
        private Button btnIndirimdekiler;
        private Button btnExit;
        private ImageList ımageList1;
    }
}
