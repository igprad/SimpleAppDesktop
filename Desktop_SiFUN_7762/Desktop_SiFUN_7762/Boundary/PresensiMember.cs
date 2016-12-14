using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop_SiFUN_7762.db_sifunTableAdapters;
using CrystalDecisions.ReportSource;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows;


namespace Desktop_SiFUN_7762.Boundary
{
    public partial class PresensiMember : Form
    {
        private int IDmember, IDpres;
        RptPresensiMember rpt = new RptPresensiMember();

        public PresensiMember()
        {
            InitializeComponent();
        }

        private TBL_DEPOSITTableAdapter tbl_deposit = new TBL_DEPOSITTableAdapter();
        private TBL_MEMBERTableAdapter tbl_member = new TBL_MEMBERTableAdapter();
        private TBL_KELASTableAdapter tbl_kelas = new TBL_KELASTableAdapter();
        private TBL_PRESENSI_MEMBERTableAdapter tbl_pres_member = new TBL_PRESENSI_MEMBERTableAdapter();

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void PresensiMember_Load(object sender, EventArgs e)
        {
            
            DataTable all = new DataTable();

            all = tbl_pres_member.GetData();

            rpt.SetDataSource(all);

            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Show();
        }

        private void kembaliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPresensiMember utama = new FormPresensiMember();
            utama.ShowDialog();
            this.Close();
        }

        public void setIDMemberIdPres(int id1, int id2,string thn_daftar,string bln_daftar,string kelas,string tarif,string deposit,string uang,string mmbr) {
            this.IDmember = id1;
            this.IDpres = id2;
            (rpt.ReportDefinition.ReportObjects["idPresensi"] as TextObject).Text = id2.ToString();
            (rpt.ReportDefinition.ReportObjects["idMember"] as TextObject).Text = id1.ToString();
            (rpt.ReportDefinition.ReportObjects["thnRegister"] as TextObject).Text = thn_daftar;
            (rpt.ReportDefinition.ReportObjects["blnRegister"] as TextObject).Text = bln_daftar;
            (rpt.ReportDefinition.ReportObjects["namaKelas"] as TextObject).Text = kelas;
            (rpt.ReportDefinition.ReportObjects["tarif"] as TextObject).Text = tarif;
            (rpt.ReportDefinition.ReportObjects["deposit"] as TextObject).Text = deposit;
            (rpt.ReportDefinition.ReportObjects["deposit_uang"] as TextObject).Text = uang;
            (rpt.ReportDefinition.ReportObjects["mmbr"] as TextObject).Text = mmbr;

        }
    }
}
