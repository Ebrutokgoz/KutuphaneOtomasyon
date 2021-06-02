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
    public partial class EmanetIslemleri : Form
    {
        KutuphaneVeriTabaniEntities db = new KutuphaneVeriTabaniEntities();
        public EmanetIslemleri()
        {
            InitializeComponent();
        }

        private void emanetVerBtn_Click(object sender, EventArgs e)
        {
            kitapPnl.Hide();
            kitapUyePnl.Show();

           
        }

        private void teslimAlBtn_Click(object sender, EventArgs e)
        {
            kitapUyePnl.Hide();
            kitapPnl.Show();
        }

        private void sorgulaBtn_Click(object sender, EventArgs e)
        {
            kitapPnl.Hide();
            kitapUyePnl.Show();
        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {

        }

        private void EmanetIslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
