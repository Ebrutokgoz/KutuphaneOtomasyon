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
    public partial class YoneticiEkrani : Form
    {
        KutuphaneVeriTabaniEntities db = new KutuphaneVeriTabaniEntities();
        public YoneticiEkrani()
        {
            InitializeComponent();
        }

        private void YoneticiEkrani_Load(object sender, EventArgs e)
        {

        }

        private void personelSayfasiBtn_Click(object sender, EventArgs e)
        {
            PersonelEkrani personelEkrani = new PersonelEkrani();
            personelEkrani.Show();
        }

        private void personelIslemleriBtn_Click(object sender, EventArgs e)
        {
            PersonelIslemleri personelIslemleri = new PersonelIslemleri();
            personelIslemleri.Show();
        }
    }
}
