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
    public partial class TamamlanmisCagrilar : Form
    {
        public TamamlanmisCagrilar()
        {
            InitializeComponent();
        }

        private void TamamlanmisCagrilar_Load(object sender, EventArgs e)
        {
            DbisTakipEntities db = new DbisTakipEntities();
            var degerler = (from x in db.TblCagrilar
                            select new
                            {
                                x.ID,
                                x.CagriFirma,
                                x.Konu,
                                x.Aciklama,
                                x.Durum

                            }).Where(y => y.Durum == false).ToList();
            gridControl1.DataSource = degerler;
        }
    }
}
