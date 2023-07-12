using is_takip_proje.Entity;
using is_takip_proje.PersonelGorevFormlari;
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
    public partial class AktifCagrilar : Form
    {
        public AktifCagrilar()
        {
            InitializeComponent();
        }

        private void AktifCagrilar_Load(object sender, EventArgs e)
        {
            DbisTakipEntities db = new DbisTakipEntities();

            var degerler = (from x in db.TblCagrilar
                            select new
                            {
                                x.ID,
                                x.TblFirmalar.Ad,
                                x.TblFirmalar.Telefon,
                                x.Konu,
                                x.Aciklama,
                               personel= x.TblPersonel.Ad,
                                x.Durum

                            }).Where(y => y.Durum == true).ToList();
            gridControl1.DataSource=degerler;   
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmCagriAtama fr = new FrmCagriAtama();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    }
}
