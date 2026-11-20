namespace PersonelTakipSistemi_UI.Formlar.BolumEkle
{
    partial class BolumEkleForm
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
            dgwBolumler = new DataGridView();
            txtBolumAd = new TextBox();
            btnBolumEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwBolumler).BeginInit();
            SuspendLayout();
            // 
            // dgwBolumler
            // 
            dgwBolumler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwBolumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwBolumler.Location = new Point(12, 134);
            dgwBolumler.Name = "dgwBolumler";
            dgwBolumler.Size = new Size(592, 201);
            dgwBolumler.TabIndex = 0;
            // 
            // txtBolumAd
            // 
            txtBolumAd.Location = new Point(230, 45);
            txtBolumAd.Name = "txtBolumAd";
            txtBolumAd.PlaceholderText = "Bölüm Adı";
            txtBolumAd.Size = new Size(135, 23);
            txtBolumAd.TabIndex = 1;
            // 
            // btnBolumEkle
            // 
            btnBolumEkle.Location = new Point(230, 74);
            btnBolumEkle.Name = "btnBolumEkle";
            btnBolumEkle.Size = new Size(135, 28);
            btnBolumEkle.TabIndex = 2;
            btnBolumEkle.Text = "Ekle";
            btnBolumEkle.UseVisualStyleBackColor = true;
            btnBolumEkle.Click += btnBolumEkle_Click;
            // 
            // BolumEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(616, 347);
            Controls.Add(btnBolumEkle);
            Controls.Add(txtBolumAd);
            Controls.Add(dgwBolumler);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BolumEkleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BolumEkle";
            Load += BolumEkle_Load;
            ((System.ComponentModel.ISupportInitialize)dgwBolumler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwBolumler;
        private TextBox txtBolumAd;
        private Button btnBolumEkle;
    }
}