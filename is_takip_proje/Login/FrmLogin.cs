using DevExpress.XtraEditors;
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

namespace is_takip_proje.Login
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        DbisTakipEntities db = new DbisTakipEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var admindegeri = db.TblAdmin.Where(x => x.Kullanici == TxtKullanici.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
            if (admindegeri != null)
            {
               
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();    
             

            }
            

            else
            {
                XtraMessageBox.Show("Hatalı Giriş Yaptınız.");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var personeldegeri = db.TblPersonel.Where(x => x.Mail == TxtKullanici.Text && x.Sifre == TxtSifre.Text).FirstOrDefault();
            if (personeldegeri != null)
            {
               
                PersonelGorevFormlari.FrmPersonelFormu fr = new PersonelGorevFormlari.FrmPersonelFormu();
                fr.mail = TxtKullanici.Text;
                fr.Show();
                this.Hide();


            }

            else
            {
                XtraMessageBox.Show("Hatalı Giriş Yaptınız.");
            }
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void hyperlinkLabelControl4_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void hyperlinkLabelControl3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
