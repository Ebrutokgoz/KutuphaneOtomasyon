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
    public partial class PersonelIslemleri : Form
    {
        KutuphaneVeriTabaniEntities db = new KutuphaneVeriTabaniEntities();
        public PersonelIslemleri()
        {
            InitializeComponent();
        }

        private void listeleBtn_Click(object sender, EventArgs e)
        {
            eklePnl.Hide();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            eklePnl.Show();
        }

        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            eklePnl.Show();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            eklePnl.Hide();
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {

        }

        private void PersonelIslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
