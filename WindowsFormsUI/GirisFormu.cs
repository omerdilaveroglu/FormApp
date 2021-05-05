using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }

        private Giris giris = new Giris();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            giris.Kullanıcı(tbxKullanıcıAdı, tbxSifre);
            //this.Hide();
        }

    }
}
