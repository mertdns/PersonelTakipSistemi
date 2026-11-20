using PersonelTakipSistemi_Business.Abstract;
using PersonelTakipSistemi_Business.Concrete;
using PersonelTakipSistemi_DTO.DTOs.Personel;
using PersonelTakipSistemi_UI.Formlar.BolumEkle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonelTakipSistemi_UI.Formlar.Personeller
{
    public partial class PersonellerForm : Form
    {
        private readonly IPersonelService personelService = new PersonelService();
        private readonly IBolumService bolumService = new BolumService();

        public PersonellerForm()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            dgwVeriler.DataSource = await personelService.SGetPersonellerWithBolumAsync();
            cmbBolumler.DataSource = await bolumService.SListele();
            cmbBolumler.DisplayMember = "BolumAd";
            cmbBolumler.ValueMember = "BolumId";
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                await personelService.SEKle(new PersonelEkleDTO()
                {
                    PersonelAd = txtAd.Text,
                    PersonelSoyad = txtSoyad.Text,
                    PersonelAdres = rctAdres.Text,
                    PersonelMaas = decimal.TryParse(txtMaas.Text, out decimal maas) ? maas : null,
                    BolumId = cmbBolumler.SelectedValue != null && Guid.TryParse(cmbBolumler.SelectedValue.ToString(), out Guid bolumId) ? bolumId : null
                });

                MessageBox.Show("Personel başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgwVeriler.DataSource = null;
                dgwVeriler.DataSource = await personelService.SGetPersonellerWithBolumAsync();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            BolumEkleForm bolumEkleForm = new BolumEkleForm();
            bolumEkleForm.ShowDialog();
        }
    }
}
