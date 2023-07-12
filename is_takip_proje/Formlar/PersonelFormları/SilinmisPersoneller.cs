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
    public partial class SilinmisPersoneller : Form
    {
        public SilinmisPersoneller()
        {
            InitializeComponent();
        }
        DbisTakipEntities db = new DbisTakipEntities();
        private void SilinmisPersoneller_Load(object sender, EventArgs e)
        {
            TblPersonel t = new TblPersonel();
            var personel = (from x in db.TblPersonel
                            select new
                            {
                                x.ID,
                                x.Ad,
                                x.Soyad,
                                x.Mail,
                                x.Telefon,
                                x.Departman,
                                x.Durum


                            }).Where(x => x.Durum == false).ToList();

            gridControl1.DataSource=personel;   



        }
    }
}
