using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class GirisEkrani : Form
    {
        KutuphaneVeriTabaniEntities db = new KutuphaneVeriTabaniEntities();
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void GirisBtn_Click(object sender, EventArgs e)
        {
            string girilenEposta = CalisanEpostaTxt.Text;
            string girilenSifre = SifreTxt.Text;

            var calisan = db.Calisanlar.Where(c => c.Calisan_eposta.Equals(girilenEposta) && c.Calisan_sifre.Equals(girilenSifre)).FirstOrDefault();

            if(calisan == null)
            {
                MessageBox.Show(text: "Personel adı veya şifer hatalı");
            }
            else
            {
                if(calisan.Unvan == "Yönetici")
                {
                    YoneticiEkrani yoneticiEkrani = new YoneticiEkrani();
                    yoneticiEkrani.Show();
                    this.Hide();
                }
                else
                {
                    PersonelEkrani personelEkrani = new PersonelEkrani();
                    personelEkrani.Show();
                    this.Hide();
                }
            }
          

        }

        private void PersonelAdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
