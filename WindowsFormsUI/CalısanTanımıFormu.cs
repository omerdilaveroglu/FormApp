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
    public partial class CalısanTanımıFormu : Form
    {
        public CalısanTanımıFormu()
        {
            InitializeComponent();
            _employeeService = new EmployeeManager(new EfEmployeeDal());

        }

        private IEmployeeService _employeeService;

        private void btnGeri_Click(object sender, EventArgs e)
        {
            AnaForm frAnaForm = new AnaForm();
            frAnaForm.Show();
            this.Hide();
        }

        private void CalısanTanımıFormu_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            dgwCalısanTanımı.DataSource = _employeeService.GetAll();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _employeeService.Add(new Employee
                {
                    Adı = tbxAdıEkle.Text,
                    Soyadı = tbxSoyadıEkle.Text,
                    TcNo = Convert.ToString(tbxTcEkle.Text),
                    Gorevi = tbxGoreviEkle.Text,
                    AylıkMaliyeti = Convert.ToDecimal(tbxAylıkMaliyetEkle.Text),
                    BirimSaatMaliyeti = Convert.ToDecimal(tbxBirimMaliyetEkle.Text)

                });
                MessageBox.Show("Eklenme işlemi başarılı");
                LoadEmployees();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            _employeeService.Delete(new Employee
            {
                Id = Convert.ToInt32(dgwCalısanTanımı.CurrentRow.Cells[0].Value)
            });
            MessageBox.Show("Silme işlemi başarılı.");
            LoadEmployees();
        }

        private void btnGücelle_Click(object sender, EventArgs e)
        {
            try
            {
                _employeeService.Update(new Employee
                {
                    Id = Convert.ToInt32(dgwCalısanTanımı.CurrentRow.Cells[0].Value),
                    Adı = tbxAdıGüncelle.Text,
                    Soyadı = tbxSoyadıGüncelle.Text,
                    TcNo = Convert.ToString(tbxTcGüncelle.Text),
                    Gorevi = tbxGoreviGüncelle.Text,
                    AylıkMaliyeti = Convert.ToDecimal(tbxAylıkMaliyetGüncelle.Text),
                    BirimSaatMaliyeti = Convert.ToDecimal(tbxBirimMaliyetGüncelle.Text)

                });
                MessageBox.Show("Güncelleme işlemi başarılı");
                LoadEmployees();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dgwCalısanTanımı_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwCalısanTanımı.CurrentRow;
            tbxAdıGüncelle.Text = row.Cells[1].Value.ToString();
            tbxSoyadıGüncelle.Text = row.Cells[2].Value.ToString();
            tbxTcGüncelle.Text = row.Cells[3].Value.ToString();
            tbxGoreviGüncelle.Text = row.Cells[4].Value.ToString();
            tbxBirimMaliyetGüncelle.Text = row.Cells[5].Value.ToString();
            tbxAylıkMaliyetGüncelle.Text = row.Cells[6].Value.ToString();

        }

        private void tbxArama_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxArama.Text))
            {
                dgwCalısanTanımı.DataSource = _employeeService.NameSearch(tbxArama.Text);
            }
            else
            {
                LoadEmployees();
            }
            
        }
    }
}
