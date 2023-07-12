using DevExpress.XtraGrid;
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
    public partial class FrmFirmaListesi : Form
    {
        public FrmFirmaListesi()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();
        private void FrmFirmaListesi_Load(object sender, EventArgs e)
        {
            var firma = (from x in db.TblFirmalar
                         select new
                         {
                             x.Ad,
                             x.Telefon,
                             x.Mail,
                             x.Sektor,
                             x.il


                         }).ToList();
            gridControl1.DataSource = firma;


        }
    }
}
