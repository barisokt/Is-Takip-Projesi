using is_takip_proje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.Formlar
{
    public partial class FrmGorevİstatistik : Form
    {
        public FrmGorevİstatistik()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();
        private void FrmGorevİstatistik_Load(object sender, EventArgs e)
        {
            LblSonGörev.Text = db.TblGorevler.OrderByDescending(x => x.ID).Select(x => x.Aciklama).FirstOrDefault();
            LblGörevTarih.Text = db.TblGorevler.OrderByDescending(x => x.ID).Select(x => x.Tarih).FirstOrDefault().ToString();
            DateTime bugun =  DateTime.Today;
            LblBugünGörev.Text = db.TblGorevler.Count(x => x.Tarih == bugun).ToString();
        }
    }
}
