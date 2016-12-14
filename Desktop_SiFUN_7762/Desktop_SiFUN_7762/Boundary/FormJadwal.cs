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
    public partial class FormJadwal : Form
    {

        int hari = 0;

        public FormJadwal()
        {
            //KURANG PENGECEKKAN JADWAL, GA BOLEH ADA TABRAKAN JADWAL
            InitializeComponent();
        }

        JadwalControl Jcontrol = new JadwalControl();

        public void TampilJadwalByHari(DataGridView data, int hari) {
            data.DataSource = Jcontrol.TampilJadwalByHari(hari);
            UbahHari(data);
            data.Columns[0].HeaderText = "ID";
            data.Columns[1].HeaderText = "Hari";
            data.Columns[2].HeaderText = "Kelas";
            data.Columns[3].HeaderText = "Pegawai";
            data.Columns[4].HeaderText = "Mulai";
            data.Columns[5].HeaderText = "Selesai";
            data.Columns["ID_KELAS"].Visible = false;
            data.Columns["ID_PEGAWAI"].Visible = false;
            data.Columns[0].Visible = false;
            data.Columns[0].Width = 50;
            data.Columns[1].Width = 150;
            data.Columns[2].Width = 200;
            data.Columns[3].Width = 100;
            data.Columns[4].Width = 130;
            data.Columns[5].Width = 136;
        }

        public void TampilJadwal(DataGridView data) {
            data.DataSource = Jcontrol.TampilJadwal();
            UbahHari(data);
            data.Columns[0].HeaderText = "ID";
            data.Columns[1].HeaderText = "Hari";
            data.Columns[2].HeaderText = "Kelas";
            data.Columns[3].HeaderText = "Pegawai";
            data.Columns[4].HeaderText = "Mulai";
            data.Columns[5].HeaderText = "Selesai";
            data.Columns["ID_KELAS"].Visible = false;
            data.Columns["ID_PEGAWAI"].Visible = false;
            data.Columns[0].Visible = false;
            data.Columns[0].Width = 50;
            data.Columns[1].Width = 150;
            data.Columns[2].Width = 200;
            data.Columns[3].Width = 100;
            data.Columns[4].Width = 130;
            data.Columns[5].Width = 136;
        }

        private void FormJadwal_Load(object sender, EventArgs e)
        {
            TampilJadwal(this.dataGridView1);
            uC_Jadwal1.setFlag(1);
            uC_Jadwal1.Visible = false;
        }

        public void disable()
        {
            dataGridView1.Enabled = false;
            this.btnTambah.Enabled = false;
            this.btnHapus.Enabled = false;
            this.btnUbah.Enabled = false;
        }

        public void enable()
        {
            dataGridView1.Enabled = true;
            this.btnTambah.Enabled = true;
            this.btnHapus.Enabled = true;
            this.btnUbah.Enabled = true;
            TampilJadwal(this.dataGridView1);
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows[0].Selected = true;
                txtID.Text = getKolom(dataGridView1, 0);
            }

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            uC_Jadwal1.setFlag(1);
            uC_Jadwal1.Visible = true;
            uC_Jadwal1.btnTambah.Text = "Tambah";
            disable();
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

        public void UbahHari(DataGridView dg) {
            int last = dg.Rows.Count;

            for (int i = 0; i < last; i++) {
                if (dg["hari", i].Value.ToString() == "1")
                    dg["hari", i].Value = "Senin";
                else if (dg["hari", i].Value.ToString() == "2")
                    dg["hari", i].Value = "Selasa";
                else if (dg["hari", i].Value.ToString() == "3")
                    dg["hari", i].Value = "Rabu";
                else if (dg["hari", i].Value.ToString() == "4")
                    dg["hari", i].Value = "Kamis";
                else if (dg["hari", i].Value.ToString() == "5")
                    dg["hari", i].Value = "Jumat";
                else if (dg["hari", i].Value.ToString() == "6")
                    dg["hari", i].Value = "Sabtu";
                else if (dg["hari", i].Value.ToString() == "7")
                    dg["hari", i].Value = "Minggu";
            }
        }

        public void EnableEdit()
        {
            dataGridView1.Enabled = true;
            btnTambah.Enabled = true;
            btnHapus.Enabled = true;
            btnUbah.Enabled = true;

            TampilJadwal(this.dataGridView1);
            //dataGridView1.Rows[int.Parse(txtRow.Text)].Selected = true;
            //txtID.Text = getKolomEdit(dataGridView1, int.Parse(txtRow.Text));
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih jadwal terlebih dahulu");
                dataGridView1.Focus();
            }
            else
            {
                uC_Jadwal1.setFlag(2);
                uC_Jadwal1.btnTambah.Text = "Ubah";
                string pegawai = getKolom(dataGridView1, 5);
                string kelas = getKolom(dataGridView1, 4);
                string hari = getKolom(dataGridView1, 1);
                uC_Jadwal1.isiTextBox(pegawai, kelas, hari, txtID.Text);
                uC_Jadwal1.Visible = true;
                txtID.Clear();
                disable();
            }
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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "")
                {
                    MessageBox.Show("Silahkan pilih data yang hendak dihapus");
                    dataGridView1.Focus();
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Apakah anda yakin menghapus data jadwal ini?", "Pertanyaan", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Jcontrol.HapusJadwal(int.Parse(txtID.Text));
                    }
                    txtID.Clear();
                    this.enable();
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void jadwalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormJadwal form = new FormJadwal();
            form.ShowDialog();
            this.Close();
        }

        private void promoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPromo form = new FormPromo();
            form.ShowDialog();
            this.Close();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMember form = new FormMember();
            form.ShowDialog();
            this.Close();
        }

        private void memberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPresensiMember form = new FormPresensiMember();
            form.ShowDialog();
            this.Close();

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

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPegawai utama = new FormPegawai();
            utama.ShowDialog();
            this.Close();
        }

        private void uC_Jadwal1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Senin") {
                hari = 1;
            }
            if (comboBox1.SelectedItem.ToString() == "Selasa")
            {
                hari = 2;
            }
            if (comboBox1.SelectedItem.ToString() == "Rabu")
            {
                hari = 3;
            }
            if (comboBox1.SelectedItem.ToString() == "Kamis")
            {
                hari = 4;
            }
            if (comboBox1.SelectedItem.ToString() == "Jumat")
            {
                hari = 5;
            }
            if (comboBox1.SelectedItem.ToString() == "Sabtu")
            {
                hari = 6;
            }

            TampilJadwalByHari(dataGridView1,hari);
        }
    }
}
