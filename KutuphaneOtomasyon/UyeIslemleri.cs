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
    public partial class UyeIslemleri : Form
    {
        KutuphaneVeriTabaniEntities db = new KutuphaneVeriTabaniEntities();
        public UyeIslemleri()
        {
            InitializeComponent();
        }

        private void uyeleriListeleBtn_Click(object sender, EventArgs e)
        {
            eklePnl.Hide();
        }

        private void uyeGuncelleBtn_Click(object sender, EventArgs e)
        {
            eklePnl.Show();
        }

        private void uyeEkleBtn_Click(object sender, EventArgs e)
        {
            eklePnl.Show();
        }

        private void uyeSilBtn_Click(object sender, EventArgs e)
        {
            eklePnl.Hide();
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {

        }

        private void UyeIslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
