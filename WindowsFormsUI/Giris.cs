using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI
{
    public class Giris
    {
        private SqlConnection baglantı =
            new SqlConnection(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=
                VizeProje;Integrated Security=True;Connect Timeout=30;Encrypt=False;
                TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private SqlCommand komut;
        private SqlDataReader read;
        private AnaForm anaform = new AnaForm();

        public SqlDataReader Kullanıcı(TextBox kullanıcıadı, TextBox sifre)
        {
            baglantı.Open();
            komut = new SqlCommand();
            komut.Connection = baglantı;
            komut.CommandText = "select * from Users where KullanıcıAdı = '" + kullanıcıadı.Text + "' ";
            read = komut.ExecuteReader();
            if (read.Read() == true)
            {
                if (sifre.Text == read["sifre"].ToString())
                {
                   MessageBox.Show("Giriş başarılı");
                   anaform.Show();
                }
                else
                {
                    MessageBox.Show("Şifrenizi kontrol ediniz");
                }

            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz.");
            }
            baglantı.Close();
            return read;
            
            

        }
    }
}
