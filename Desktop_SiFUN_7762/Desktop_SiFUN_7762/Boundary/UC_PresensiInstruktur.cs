using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop_SiFUN_7762.Control;
using Desktop_SiFUN_7762.Entity;

namespace Desktop_SiFUN_7762.Boundary
{
    public partial class UC_PresensiInstruktur : UserControl
    {
        PresensiControl con = new PresensiControl();
        JadwalControl jadwalController = new JadwalControl();

        int flagperintah = 0;

        public void setFlag(int flag)
        {
            flagperintah = flag;
        }

        public UC_PresensiInstruktur()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void tampilJadwalUpdate(DataGridView data)
        {
            data.DataSource = jadwalController.TampilJadwalUpToDate();
            data.Columns[0].HeaderText = "ID";
            data.Columns[1].HeaderText = "Hari";
            data.Columns[2].HeaderText = "Kelas";
            data.Columns[3].HeaderText = "Pegawai";
            data.Columns[4].HeaderText = "Mulai";
            data.Columns[5].HeaderText = "Selesai";
            data.Columns["NAMA_KELAS"].HeaderText = "Kelas";
            data.Columns["NAMA_PEGAWAI"].HeaderText = "Instruktur";
            data.Columns["ID_KELAS"].Visible = false;
            data.Columns["ID_PEGAWAI"].Visible = false;
            data.Columns["HARI"].Visible = false;
            data.Columns[0].Visible = false;
            data.Columns[0].Width = 50;
            data.Columns[1].Width = 150;
            data.Columns[2].Width = 150;
            data.Columns[3].Width = 100;
            data.Columns[4].Width = 130;
            data.Columns[5].Width = 136;
        }

        private void UC_PresensiInstruktur_Load(object sender, EventArgs e)
        {
            cmbIDPegawai.DataSource = jadwalController.TampilJadwalUpToDate();
            cmbIDPegawai.DisplayMember = "NAMA_PEGAWAI";
            cmbIDPegawai.ValueMember = "ID_PEGAWAI";
            tampilJadwalUpdate(dataGridView1);

        }

        private string getKolom(DataGridView dg, int i)
        {
            return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
        }

        private string getKolomEdit(DataGridView dg, int i)
        {
            return dg[dg.Columns[0].Index, dg.Rows[i].Index].Value.ToString();
        }

        private string getRow(DataGridView dg)
        {
            return dg.CurrentRow.Index.ToString();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            cleartxt();
            errorProvider1.Clear();
            this.Hide();
            FormPresensiInstruktur myParent = (FormPresensiInstruktur)this.Parent;
            myParent.enable();
        }

        private bool cektxt()
        {
            bool temp = true;
            return temp;
        }

        private void cleartxt()
        {
            txtKeterangan.Clear();
            cmbJadwal.SelectedIndex = -1;
            cmbIDPegawai.SelectedIndex = -1;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (flagperintah == 1)
            {
                if (cektxt() == true)
                {
                    errorProvider1.Clear();
                    PresensiInstrukturEntity input = new
                        PresensiInstrukturEntity(int.Parse(cmbIDPegawai.SelectedValue.ToString()),int.Parse(cmbJadwal.Text.ToString()), DateTime.Now, txtKeterangan.Text);
                    con.EntryPresensiPegawai(input);
                    //con.UpdatePointPegawai(con.GetPointPresensiById(con.GetLastIdPresensi()), int.Parse(cmbIDPegawai.SelectedValue.ToString()));
                    cleartxt();
                    this.Hide();
                    FormPresensiInstruktur myParent = (FormPresensiInstruktur)this.Parent;
                    myParent.enable();
                }
            }
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            //cmbJadwal.DataSource = con.ListJadwalByInstruktur(int.Parse(cmbIDPegawai.SelectedValue.ToString()));
            //cmbJadwal.DisplayMember = "NAMA_KELAS";
            //cmbJadwal.ValueMember = "ID_JADWAL";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbJadwal.Text = getKolom(dataGridView1, 0);
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmbJadwal.Text = getKolom(dataGridView1, 0);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbJadwal.Text = getKolom(dataGridView1, 0);
        }


    }
}
