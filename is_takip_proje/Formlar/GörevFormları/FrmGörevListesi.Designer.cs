namespace is_takip_proje.Formlar
{
    partial class FrmGörevListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGörevListesi));
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.LblToplamDepartman = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.LblAktifGörev = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.LblTamamlanmisGörev = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(513, 357);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1227, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.Red;
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.Controls.Add(this.LblToplamDepartman);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Controls.Add(this.pictureEdit1);
            this.panelControl4.Location = new System.Drawing.Point(555, 12);
            this.panelControl4.LookAndFeel.SkinMaskColor = System.Drawing.Color.Red;
            this.panelControl4.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.WhiteSmoke;
            this.panelControl4.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.panelControl4.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(204, 106);
            this.panelControl4.TabIndex = 7;
            // 
            // LblToplamDepartman
            // 
            this.LblToplamDepartman.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToplamDepartman.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblToplamDepartman.Appearance.Options.UseFont = true;
            this.LblToplamDepartman.Appearance.Options.UseForeColor = true;
            this.LblToplamDepartman.Location = new System.Drawing.Point(66, 35);
            this.LblToplamDepartman.Name = "LblToplamDepartman";
            this.LblToplamDepartman.Size = new System.Drawing.Size(19, 36);
            this.LblToplamDepartman.TabIndex = 11;
            this.LblToplamDepartman.Text = "0";
            this.LblToplamDepartman.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(143, 21);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Toplam Departman";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(132, 35);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomPercent = 45D;
            this.pictureEdit1.Size = new System.Drawing.Size(72, 66);
            this.pictureEdit1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(18)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.LblAktifGörev);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.pictureEdit2);
            this.panelControl1.Location = new System.Drawing.Point(807, 12);
            this.panelControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.ForestGreen;
            this.panelControl1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.WhiteSmoke;
            this.panelControl1.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(204, 106);
            this.panelControl1.TabIndex = 8;
            // 
            // LblAktifGörev
            // 
            this.LblAktifGörev.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAktifGörev.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblAktifGörev.Appearance.Options.UseFont = true;
            this.LblAktifGörev.Appearance.Options.UseForeColor = true;
            this.LblAktifGörev.Location = new System.Drawing.Point(64, 35);
            this.LblAktifGörev.Name = "LblAktifGörev";
            this.LblAktifGörev.Size = new System.Drawing.Size(19, 36);
            this.LblAktifGörev.TabIndex = 14;
            this.LblAktifGörev.Text = "0";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(30, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(129, 21);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Aktif Görev Sayısı";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(130, 35);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.ZoomPercent = 11D;
            this.pictureEdit2.Size = new System.Drawing.Size(72, 66);
            this.pictureEdit2.TabIndex = 12;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(18)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.LblTamamlanmisGörev);
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.pictureEdit3);
            this.panelControl2.Location = new System.Drawing.Point(1056, 12);
            this.panelControl2.LookAndFeel.SkinMaskColor = System.Drawing.Color.DarkCyan;
            this.panelControl2.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Transparent;
            this.panelControl2.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(204, 106);
            this.panelControl2.TabIndex = 8;
            // 
            // LblTamamlanmisGörev
            // 
            this.LblTamamlanmisGörev.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTamamlanmisGörev.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblTamamlanmisGörev.Appearance.Options.UseFont = true;
            this.LblTamamlanmisGörev.Appearance.Options.UseForeColor = true;
            this.LblTamamlanmisGörev.Location = new System.Drawing.Point(64, 35);
            this.LblTamamlanmisGörev.Name = "LblTamamlanmisGörev";
            this.LblTamamlanmisGörev.Size = new System.Drawing.Size(19, 36);
            this.LblTamamlanmisGörev.TabIndex = 17;
            this.LblTamamlanmisGörev.Text = "0";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(3, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(199, 21);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Tamamlanmış Görev Sayısı";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(130, 35);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.ZoomPercent = 10D;
            this.pictureEdit3.Size = new System.Drawing.Size(72, 66);
            this.pictureEdit3.TabIndex = 15;
            // 
            // chartControl1
            // 
            this.chartControl1.Location = new System.Drawing.Point(519, 124);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Durum";
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(752, 234);
            this.chartControl1.TabIndex = 9;
            // 
            // FrmGörevListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 356);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmGörevListesi";
            this.Text = "Görev Listesi";
            this.Load += new System.EventHandler(this.FrmGörevListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.LabelControl LblToplamDepartman;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl LblAktifGörev;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl LblTamamlanmisGörev;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
    }
}