using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.Concrate;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace WindowsFormsUI
{
    public partial class ReceteTanımıFormu : Form
    {
        public ReceteTanımıFormu()
        {
            InitializeComponent();
            _prescriptionService = new PrescriptionManager(new EfPrescriptionDal());
        }

        private IPrescriptionService _prescriptionService;
        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaForm frAnaForm = new AnaForm();
            frAnaForm.Show();
            this.Hide();

        }

        private void ReceteTanımıFormu_Load(object sender, EventArgs e)
        {
            LoadPrescription();
        }

        private void LoadPrescription()
        {
            dgwReceteTanımı.DataSource = _prescriptionService.GetAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _prescriptionService.Add(new Prescription
                {
                    Acıklama = tbxAcıklamaEkle.Text,
                    AnaUrunKodu = tbxAnaUrunKoduEkle.Text,
                    MiktarSayısı = Convert.ToInt32(tbxMiktarSayısıEkle.Text),
                    SatırSayısı = Convert.ToInt32(tbxSatırsayısıEkle.Text)

                });
                MessageBox.Show("Ekleme işlemi başarılı.");
                LoadPrescription();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _prescriptionService.Update(new Prescription
                {
                    Id = Convert.ToInt32(dgwReceteTanımı.CurrentRow.Cells[0].Value),
                    Acıklama = tbxAcıklamaGuncelle.Text,
                    AnaUrunKodu = tbxAnaUrunKoduGuncelle.Text,
                    MiktarSayısı = Convert.ToInt32(tbxMiktarSayısıGuncelle.Text),
                    SatırSayısı = Convert.ToInt32(tbxSatırsayısıGuncelle.Text)

                });
                MessageBox.Show("Güncelleme işlemi başarılı.");
                LoadPrescription();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgwReceteTanımı_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwReceteTanımı.CurrentRow;
            tbxAnaUrunKoduGuncelle.Text = row.Cells[1].Value.ToString();
            tbxMiktarSayısıGuncelle.Text = row.Cells[2].Value.ToString();
            tbxSatırsayısıGuncelle.Text = row.Cells[3].Value.ToString();
            tbxAcıklamaGuncelle.Text = row.Cells[4].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _prescriptionService.Delete(new Prescription
            {
                Id = Convert.ToInt32(dgwReceteTanımı.CurrentRow.Cells[0].Value)
            });
            LoadPrescription();
            MessageBox.Show("Silindi");
        }
    }
}
