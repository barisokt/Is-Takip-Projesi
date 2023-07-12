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
    public partial class TamamlananGorevler : Form
    {
        public TamamlananGorevler()
        {
            InitializeComponent();
        }
        private void TamamlananGorevler_Load_1(object sender, EventArgs e)
        {

            DbisTakipEntities db = new DbisTakipEntities();
            var degerler = (from x in db.TblGorevler
                            select new
                            {
                                x.ID,
                                x.GorevVeren,
                                x.GorevAlan,
                                x.Aciklama,
                                x.Durum

                            }).Where(y => y.Durum == false).ToList();
            gridControl1.DataSource = degerler;
        }
    }
}
