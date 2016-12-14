using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop_SiFUN_7762.Control;

namespace Desktop_SiFUN_7762.Boundary
{
    public partial class FormPresensiMember : Form
    {

        PresensiControl PresCon = new PresensiControl();

        public FormPresensiMember()
        {
            InitializeComponent();
        }

        public void TampilJadwal(DataGridView data,int Member) {
            dataGridView1.DataSource = PresCon.TampilJadwalByIdMember(Member);
            data.Columns[0].Visible = false;
            data.Columns[1].Visible = false;
            data.Columns[2].Visible = false;
            data.Columns[3].Visible = false;
            data.Columns[4].Visible = false;
            data.Columns[4].HeaderText = "Kelas Senam";
            data.Columns[5].HeaderText = "Jam Mulai";
            data.Columns[6].HeaderText = "Jam Selesai";
            data.Columns[4].Width = 240;
            data.Columns[5].Width = 230;
            data.Columns[6].Width = 230;
        }

        public void TampilPresensiMember(DataGridView data) {
            dataGridView1.DataSource = PresCon.TampilPresensiMember();

            data.Columns[2].Visible = false;
            //data.Columns[4].Visible = false;
            data.Columns["Nama"].DisplayIndex = 1;
            data.Columns["Keterangan"].DisplayIndex = 3;
            data.Columns[0].HeaderText = "ID";
            data.Columns[3].HeaderText = "Nama";
            data.Columns[1].HeaderText = "Jam Kedatangan";
            data.Columns[2].HeaderText = "Keterangan";
            //data.Columns["JAM"].Width = 300;
            data.Columns[0].Width = 50;
            data.Columns[3].Width = 500;
            data.Columns[1].Width = 500;
            data.Columns[2].Width = 300;
        }

        public void TampilPresensiMemberByHariDanKelas(DataGridView data,int id_kelas,decimal hari)
        {
            dataGridView1.DataSource = PresCon.TampilJadwalByHariDanIdKelas(id_kelas,hari);

            data.Columns[2].Visible = false;
            //data.Columns[4].Visible = false;
            data.Columns["Nama"].DisplayIndex = 0;
            data.Columns["Keterangan"].DisplayIndex = 2;
            data.Columns[0].Visible = false;
            data.Columns["Jam_Kedatangan"].Visible = false;
            data.Columns["JAM"].DisplayIndex = 1;
            data.Columns[3].HeaderText = "Nama";
            data.Columns[1].HeaderText = "Kedatangan";
            data.Columns[2].HeaderText = "Keterangan";
            data.Columns["JAM"].Width = 365;
            data.Columns[0].Width = 500;
            data.Columns[3].Width = 500;
            data.Columns[1].Width = 500;
            data.Columns[2].Width = 300;
        }

        private void FormPresensiMember_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTanggal.Text = DateTime.Now.ToString();
            //TampilPresensiMember(dataGridView1);
            uC_Presensi_Member1.setFlag(1);
            uC_Presensi_Member1.Visible = false;
            comboBox1.DataSource = PresCon.ListKelas();
            comboBox1.DisplayMember = "NAMA_KELAS";
            comboBox1.ValueMember = "ID_KELAS";
            TampilPresensiMemberByHariDanKelas(dataGridView1, 1, decimal.Parse(DateTime.Now.ToString("dd")));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTanggal.Text = DateTime.Now.ToString();
        }

        public void disable()
        {
            dataGridView1.Enabled = false;
            this.btnTambah.Enabled = false;
            this.btnCetak.Enabled = false;
        }

        public void enable()
        {
            dataGridView1.Enabled = true;
            this.btnTambah.Enabled = true;
            this.btnCetak.Enabled = true;
            //TampilPresensiMember(this.dataGridView1);
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows[0].Selected = true;
                txtID.Text = getKolom(dataGridView1, 0);
            }

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            uC_Presensi_Member1.Visible = true;
            disable();
        }

        private string getKolom(DataGridView dg, int i)
        {
            if (dataGridView1.Rows.Count == 0) {
                return null;
            }
            return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
        }

        private string getKolom2(DataGridView dg, string i)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return null;
            }
            return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
        }

        private string getKolomEdit(DataGridView dg, int i)
        {
            return dg[dg.Columns[0].Index, dg.Rows[i].Index].Value.ToString();
        }

        private string getRow(DataGridView dg)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return null;
            }
            return dg.CurrentRow.Index.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridView1, 0);
            txtRow.Text = getRow(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = getKolom(dataGridView1, 0);
            txtRow.Text = getRow(dataGridView1);
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            txtID.Text = getKolom(dataGridView1, 0);
            txtRow.Text = getRow(dataGridView1);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin utama = new FormLogin();
            utama.ShowDialog();
            this.Close();

        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Anda Yakin Ingin Keluar?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                this.Dispose();
            }

        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih presensi terlebih dahulu");
                dataGridView1.Focus();
            }
            else
            {

                int idMember = PresCon.GetIdMemberByName(getKolom(dataGridView1, 3));
                string member = PresCon.GetNamaMemberById(idMember);
                string thnRegister = PresCon.getTahunDaftarByIdMember(idMember).Year.ToString().Substring(2,2);
                string blnRegister = PresCon.getTahunDaftarByIdMember(idMember).Month.ToString();
                string keterangan = PresCon.getKeteranganByPresensi(int.Parse(txtID.Text));
                string id_jadwal = new String(keterangan.Where(Char.IsDigit).ToArray());
                int idPres = int.Parse(getKolom2(dataGridView1,"ID_PRESENSI_MEMBER"));
                string kelas = PresCon.GetNamaKelasByIdPresensiMember(idPres);
                string tarif = PresCon.GetHargaKelasByIdMemberDanIdKelas(idPres).ToString();
                string deposit_uang = PresCon.GetDepositUangByIdMember(idMember).ToString();
                string deposit_pertemuan = PresCon.GetDepositByIdMemberDanKelas(PresCon.GetIdKelas(kelas), idMember).ToString();
                this.Hide();
                PresensiMember utama = new PresensiMember();
                utama.setIDMemberIdPres(idMember, idPres, blnRegister + ".", thnRegister + ".", kelas, tarif, deposit_pertemuan, deposit_uang, member);
                utama.ShowDialog();
                this.Close();
                txtID.Clear();

            }
        }

        private void btnCetak_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //this.dataGridView1.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaksi utama = new Transaksi();
            utama.ShowDialog();
            this.Close();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TampilPresensiMemberByHariDanKelas(dataGridView1, int.Parse(comboBox1.SelectedValue.ToString()), decimal.Parse(dateTimePicker1.Value.ToString("dd")));
            }
            catch (Exception ex) {
                TampilPresensiMember(dataGridView1);
                ex.ToString();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TampilPresensiMemberByHariDanKelas(dataGridView1, int.Parse(comboBox1.SelectedValue.ToString()), decimal.Parse(dateTimePicker1.Value.ToString("dd")));
            }
            catch (Exception ex)
            {
                TampilPresensiMember(dataGridView1);
                ex.ToString();
            }
        }

        private void uC_Presensi_Member1_Load(object sender, EventArgs e)
        {

        }
    }
}
