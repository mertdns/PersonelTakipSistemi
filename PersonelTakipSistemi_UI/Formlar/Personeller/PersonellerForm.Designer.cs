namespace PersonelTakipSistemi_UI.Formlar.Personeller
{
    partial class PersonellerForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtMaas = new TextBox();
            rctAdres = new RichTextBox();
            lblAdres = new Label();
            btnKaydet = new Button();
            dgwVeriler = new DataGridView();
            cmbBolumler = new ComboBox();
            lblBolumler = new Label();
            btnBolumEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwVeriler).BeginInit();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(45, 32);
            txtAd.Name = "txtAd";
            txtAd.PlaceholderText = "Ad";
            txtAd.Size = new Size(253, 23);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(45, 78);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.PlaceholderText = "Soyad";
            txtSoyad.Size = new Size(253, 23);
            txtSoyad.TabIndex = 1;
            // 
            // txtMaas
            // 
            txtMaas.Location = new Point(45, 128);
            txtMaas.Name = "txtMaas";
            txtMaas.PlaceholderText = "Maaş";
            txtMaas.Size = new Size(253, 23);
            txtMaas.TabIndex = 2;
            // 
            // rctAdres
            // 
            rctAdres.Location = new Point(45, 258);
            rctAdres.Name = "rctAdres";
            rctAdres.Size = new Size(253, 96);
            rctAdres.TabIndex = 3;
            rctAdres.Text = "";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Location = new Point(45, 240);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(40, 15);
            lblAdres.TabIndex = 4;
            lblAdres.Text = "Adres:";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(99, 370);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(130, 40);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // dgwVeriler
            // 
            dgwVeriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwVeriler.Location = new Point(345, 22);
            dgwVeriler.Name = "dgwVeriler";
            dgwVeriler.Size = new Size(527, 386);
            dgwVeriler.TabIndex = 6;
            // 
            // cmbBolumler
            // 
            cmbBolumler.FormattingEnabled = true;
            cmbBolumler.Location = new Point(45, 196);
            cmbBolumler.Name = "cmbBolumler";
            cmbBolumler.Size = new Size(121, 23);
            cmbBolumler.TabIndex = 7;
            // 
            // lblBolumler
            // 
            lblBolumler.AutoSize = true;
            lblBolumler.Location = new Point(45, 176);
            lblBolumler.Name = "lblBolumler";
            lblBolumler.Size = new Size(58, 15);
            lblBolumler.TabIndex = 8;
            lblBolumler.Text = "Bölümler:";
            // 
            // btnBolumEkle
            // 
            btnBolumEkle.Font = new Font("Segoe UI", 12F);
            btnBolumEkle.Location = new Point(331, 448);
            btnBolumEkle.Name = "btnBolumEkle";
            btnBolumEkle.Size = new Size(232, 52);
            btnBolumEkle.TabIndex = 9;
            btnBolumEkle.Text = "Bölüm Ekle";
            btnBolumEkle.UseVisualStyleBackColor = true;
            btnBolumEkle.Click += btnBolumEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 525);
            Controls.Add(btnBolumEkle);
            Controls.Add(lblBolumler);
            Controls.Add(cmbBolumler);
            Controls.Add(dgwVeriler);
            Controls.Add(btnKaydet);
            Controls.Add(lblAdres);
            Controls.Add(rctAdres);
            Controls.Add(txtMaas);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Takip Sistemi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwVeriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtMaas;
        private RichTextBox rctAdres;
        private Label lblAdres;
        private Button btnKaydet;
        private DataGridView dgwVeriler;
        private ComboBox cmbBolumler;
        private Label lblBolumler;
        private Button btnBolumEkle;
    }
}