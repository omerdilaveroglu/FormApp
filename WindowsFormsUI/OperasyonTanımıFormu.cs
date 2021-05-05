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
    public partial class OperasyonTanımıFormu : Form
    {
        public OperasyonTanımıFormu()
        {
            InitializeComponent();
            _operationalDefinitionService = new OperationalDefinitionManager(new EfOperationalDefinitionDal());
        }

        private IOperationalDefinitionService _operationalDefinitionService;

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaForm frAnaForm = new AnaForm();
            frAnaForm.Show();
            this.Hide();
        }

        private void OperasyonTanımıFormu_Load(object sender, EventArgs e)
        {
            loadOperationalDefinition();
        }

        private void loadOperationalDefinition()
        {
            dgwReceteTanımı.DataSource = _operationalDefinitionService.GetAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _operationalDefinitionService.Add( new OperationalDefinition
                {
                    BeklemeSuresi =Convert.ToInt32(tbxBeklemeSuresiEkle.Text),
                    IslemSuresi = Convert.ToInt32(tbxIslemSuresiEkle.Text),
                    OperasyonAcıklama = tbxOperasyonAcıklamasıEkle.Text,
                    OperasyonKodu = tbxOperasyonKoduEkle.Text,
                    TasımaSuresi = Convert.ToInt32(tbxTasımaSuresiEkle.Text),
                    ToplamOperasyonSuresi = Convert.ToInt32(tbxToplamOperasyonSuresiEkle.Text)
                });
                loadOperationalDefinition();
                MessageBox.Show("Ekleme işlemi başarılı");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
