using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcKimlikDogrula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SorguButton_Click(object sender, EventArgs e)
        {
            KimlikDogrulama.KPSPublicSoapClient KK = new KimlikDogrulama.KPSPublicSoapClient();
            
            long TCKN = long.Parse(TcTextBox.Text);
            string Ad = AdTextBox.Text;
            string Soyad = SoyadTextBox.Text;
            int DogumYil = int.Parse(YilTextBox.Text);

            bool Sorgu = KK.TCKimlikNoDogrula(TCKN, Ad, Soyad, DogumYil);
            if (Sorgu)
            {
                MessageBox.Show("Başarılı !");
            }
            else
            {
                MessageBox.Show("Girilen bilgilere ait vatandaş bulunamadı.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
