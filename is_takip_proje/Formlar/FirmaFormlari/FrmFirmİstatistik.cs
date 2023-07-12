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
    public partial class FrmFirmİstatistik : Form
    {
        public FrmFirmİstatistik()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();

        private void FrmFirmİstatistik_Load(object sender, EventArgs e)
        {
            LblFirmaSayısı.Text = db.TblFirmalar.Count().ToString();
            LblŞehir.Text = db.TblFirmalar.Select(x => x.il).Distinct().Count().ToString();
            LblSektörSayısı.Text = db.TblFirmalar.Select(x => x.Sektor).Distinct().Count().ToString();
        }
    }
}
