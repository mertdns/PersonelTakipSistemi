using PersonelTakipSistemi_Business.Abstract;
using PersonelTakipSistemi_Business.Concrete;
using PersonelTakipSistemi_Business.Config;
using PersonelTakipSistemi_DTO.DTOs.Bolum;
using System.ComponentModel.DataAnnotations;

namespace PersonelTakipSistemi_UI.Formlar.BolumEkle
{
    public partial class BolumEkleForm : Form
    {
        private readonly IBolumService bolumService = new BolumService();

        public BolumEkleForm()
        {
            InitializeComponent();
        }

        private async void btnBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                await bolumService.SEKle(new BolumEkleDTO() { BolumAd = txtBolumAd.Text });

                dgwBolumler.DataSource = null;
                dgwBolumler.DataSource = MapperConfig.Mapper.Map<List<BolumEkleDTO>>(await bolumService.SListele());

                txtBolumAd.Text = "";

                MessageBox.Show("Bölüm başarıyla eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
;            }
            catch (ValidationException ex)
            {
                txtBolumAd.Focus();
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BolumEkle_Load(object sender, EventArgs e)
        {
            dgwBolumler.DataSource = MapperConfig.Mapper.Map<List<BolumEkleDTO>>(await bolumService.SListele());
        }
    }
}
