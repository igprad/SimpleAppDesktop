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
    public partial class FormPresensiInstruktur : Form
    {
        public FormPresensiInstruktur()
        {
            InitializeComponent();
        }

        PresensiControl con = new PresensiControl();

        public void TampilPresensiInstrukturHariDanKelas(DataGridView data,int id,string date)
        {
            dataGridView1.DataSource = con.TampilPresensiInstrukturByHariAndKelas(id,date);
            data.Columns[0].HeaderText = "ID";
            data.Columns["ID_PRESENSI"].Visible = false;
            data.Columns[4].HeaderText = "Kelas";
            data.Columns[1].HeaderText = "Kedatangan";
            data.Columns[2].HeaderText = "Keterangan";
            data.Columns[3].HeaderText = "Instruktur";
            data.Columns[0].Width = 50;
            data.Columns[4].Width = 190;
            data.Columns[2].Width = 500;
            data.Columns[3].Width = 300;
            data.Columns["Nama_Pegawai"].DisplayIndex = 1;
            data.Columns["Keterangan"].DisplayIndex = 4;
            data.Columns["NAMA_KELAS"].DisplayIndex = 2;
            data.Columns["JAM"].DisplayIndex = 3;
            data.Columns["JAM"].Width = 150;
            data.Columns["JAM_KEDATANGAN"].Visible = false;
        }

        public void TampilPresensiInstruktur(DataGridView data) {
            dataGridView1.DataSource = con.TampilPresensiInstruktur();
            data.Columns[0].HeaderText = "ID";
            data.Columns[4].HeaderText = "Kelas";
            data.Columns[1].HeaderText = "Kedatangan";
            data.Columns[2].HeaderText = "Keterangan";
            data.Columns[3].HeaderText = "Instruktur";
            data.Columns[0].Width = 50;
            data.Columns[4].Width = 190;
            data.Columns[2].Width = 260;
            data.Columns["Nama_Pegawai"].DisplayIndex = 1;
            data.Columns["Keterangan"].DisplayIndex = 4;
            data.Columns["NAMA_KELAS"].DisplayIndex = 2;
            data.Columns["JAM_KEDATANGAN"].DisplayIndex = 3;
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

        private void FormPresensiInstruktur_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTanggal.Text = DateTime.Now.ToString();
            //TampilPresensiInstruktur(dataGridView1);
            uC_PresensiInstruktur1.setFlag(1);
            uC_PresensiInstruktur1.Visible = false;
            comboBox1.DataSource = con.ListKelas();
            comboBox1.DisplayMember = "NAMA_KELAS";
            comboBox1.ValueMember = "ID_KELAS";
            //TampilPresensiInstrukturHariDanKelas(dataGridView1,1, DateTime.Now.ToString("yyyy/MM/dd"));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTanggal.Text = DateTime.Now.ToString();
        }

        public void disable()
        {
            dataGridView1.Enabled = false;
            this.btnTambah.Enabled = false;
        }

        public void enable()
        {
            dataGridView1.Enabled = true;
            this.btnTambah.Enabled = true;
            //TampilPresensiInstruktur(this.dataGridView1);
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows[0].Selected = true;
                //txtID.Text = getKolom(dataGridView1, 0);
            }

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            uC_PresensiInstruktur1.Visible = true;
            disable();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                TampilPresensiInstrukturHariDanKelas(dataGridView1, int.Parse(comboBox1.SelectedValue.ToString()), dateTimePicker1.Value.Date.ToString("yyyy/MM/dd"));
            }
            catch (Exception ex)
            {
                ex.ToString();
                TampilPresensiInstrukturHariDanKelas(dataGridView1, 1, DateTime.Now.ToString("yyyy/MM/dd"));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TampilPresensiInstrukturHariDanKelas(dataGridView1, int.Parse(comboBox1.SelectedValue.ToString()), dateTimePicker1.Value.Date.ToString("yyyy/MM/dd"));
            }
            catch (Exception ex) {
                ex.ToString();
                TampilPresensiInstrukturHariDanKelas(dataGridView1, 1, DateTime.Now.ToString("yyyy/MM/dd"));
            }
        }
    }
}
