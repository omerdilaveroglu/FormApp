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
    public partial class IsIstasyonuFormu : Form
    {
        public IsIstasyonuFormu()
        {
            InitializeComponent();
            _workStationService = new WorkStationManager(new EfWorkStationDal());
        }

        private IWorkStationService _workStationService;
        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaForm frAnaForm = new AnaForm();
            frAnaForm.Show();
            this.Hide();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _workStationService.Add(new WorkStation
                {
                    IsIstasyonKodu = tbxIsIstasyonKoduEkle.Text,
                    HammaddeAmbarı = tbxHammaddeAmbarıEkle.Text,
                    IstasyonAcıklama = tbxAcıklamaEkle.Text,
                    IstasyonMaliyeti = Convert.ToDecimal(tbxIstasyonMaliyetiEkle.Text)

                });
                MessageBox.Show("Ekleme işlemi başarılı");
                LoadWorkStation();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _workStationService.Update(new WorkStation
                {
                    Id = Convert.ToInt32(dgwReceteTanımı.CurrentRow.Cells[0].Value),
                    IsIstasyonKodu = tbxIsIstasyonKoduGuncelle.Text,
                    HammaddeAmbarı = tbxHammaddeAmbarıGuncelle.Text,
                    IstasyonAcıklama = tbxAcıklamaGuncelle.Text,
                    IstasyonMaliyeti = Convert.ToDecimal(tbxIstasyonMaliyetiGuncelle.Text)
                });
                MessageBox.Show("Güncelleme işlemi başarılı");
                LoadWorkStation();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void IsIstasyonuFormu_Load(object sender, EventArgs e)
        {
            LoadWorkStation();
        }

        private void LoadWorkStation()
        {
            dgwReceteTanımı.DataSource = _workStationService.GetAll();
        }


        private void dgwReceteTanımı_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwReceteTanımı.CurrentRow;
            tbxIsIstasyonKoduGuncelle.Text = row.Cells[1].Value.ToString();
            tbxAcıklamaGuncelle.Text = row.Cells[2].Value.ToString();
            tbxHammaddeAmbarıGuncelle.Text = row.Cells[3].Value.ToString();
            tbxIstasyonMaliyetiGuncelle.Text = row.Cells[4].Value.ToString();
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _workStationService.Delete(new WorkStation
            {
                Id = Convert.ToInt32(dgwReceteTanımı.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Silme işlemi başarılı.");
            LoadWorkStation();
        }
    }
}
