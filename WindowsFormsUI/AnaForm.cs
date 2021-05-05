using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void CalısanT_Click(object sender, EventArgs e)
        {
            CalısanTanımıFormu frCalısanTanımıFormu = new CalısanTanımıFormu();
            frCalısanTanımıFormu.Show();
            this.Hide();
        }

        private void IsIstasyonT_Click(object sender, EventArgs e)
        {
            IsIstasyonuFormu frIsIstasyonuFormu = new IsIstasyonuFormu();
            frIsIstasyonuFormu.Show();
            this.Hide();
        }

        private void ReceteT_Click(object sender, EventArgs e)
        {
            ReceteTanımıFormu frrReceteTanımıFormu = new ReceteTanımıFormu();
            frrReceteTanımıFormu.Show();
            this.Hide();
        }

        private void OperasyonT_Click(object sender, EventArgs e)
        {
            OperasyonTanımıFormu frOperasyonTanımıFormu = new OperasyonTanımıFormu();
            frOperasyonTanımıFormu.Show();
            this.Hide();

        }

        
    }
}
