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
    public partial class FormMember : Form
    {
        private string pegawai = "";

        public string Pegawai
        {
            get { return pegawai; }
            set { pegawai = value; }
        }


        public FormMember()
        {
            InitializeComponent();
        }

        MemberControl Mcontrol = new MemberControl();

        public void TampilMember(DataGridView data) {
            data.DataSource = Mcontrol.TampilMember();

            data.Columns[0].HeaderText = "ID";
            data.Columns["ID_MEMBER"].Visible = false;
            data.Columns[1].HeaderText = "Nama";
            data.Columns[2].HeaderText = "Alamat";
            data.Columns[3].HeaderText = "Email";
            data.Columns[4].HeaderText = "Deposit Uang";
            data.Columns[5].HeaderText = "Status";
            //data.Columns[6].HeaderText = "Username";
            data.Columns[6].Visible = false;
            data.Columns[7].HeaderText = "No Member";
            data.Columns[8].HeaderText = "Tanggal Habis Aktif";
            data.Columns[9].HeaderText = "Tanggal Daftar";

            data.Columns[0].Width = 36;
            data.Columns[1].Width = 100;
            data.Columns[2].Width = 100;
            data.Columns[3].Width = 100;
            data.Columns[4].Width = 100;
            data.Columns[5].Width = 80;
            data.Columns[6].Width = 100;
            data.Columns[7].Width = 100;
        }

        public void CariMember(DataGridView data,string key)
        {
            data.DataSource = Mcontrol.TampilMemberBy(key);

            data.Columns[0].HeaderText = "ID";
            data.Columns[1].HeaderText = "Nama";
            data.Columns[2].HeaderText = "Alamat";
            data.Columns[3].HeaderText = "Email";
            data.Columns[4].HeaderText = "Deposit Uang";
            data.Columns[5].HeaderText = "Status";
            data.Columns[6].HeaderText = "Tanggal Habis Aktif";
            data.Columns[7].HeaderText = "Username";

            data.Columns[0].Width = 36;
            data.Columns[1].Width = 100;
            data.Columns[2].Width = 100;
            data.Columns[3].Width = 100;
            data.Columns[4].Width = 100;
            data.Columns[5].Width = 80;
            data.Columns[6].Width = 100;
            data.Columns[7].Width = 100;
        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            int temp = 0;
            temp=Mcontrol.DeaktivasiMember();
            if (temp == 0)
            {
                MessageBox.Show("Tidak ada member yang perlu di deaktivasi");
            }
            else
            {
                MessageBox.Show("Ada " + temp + " Pegawai yang ter-deaktivasi");
                if (Mcontrol.cekAdaTidakRecordMember(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString()) == 0)
                    Mcontrol.InsertRecordMemberBaru(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString(), Mcontrol.totalMemberAktif(), Mcontrol.totalMemberNonAktif(),
                        Mcontrol.totalMemberAktif() + Mcontrol.totalMemberNonAktif());
                
                for (int i = 0; i < temp; i++) {
                    Mcontrol.ubahNonAktifMember(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
                }
            }
            TampilMember(this.dataGridView1);
            uC_Member1.Visible = false;
            uC_Member1.setFlag(1);

            if (Pegawai == "Kasir")
            {
                dataMasterToolStripMenuItem.Visible = false;
            }
            else {
                transaksiToolStripMenuItem.Visible = false;
                presensiMemberToolStripMenuItem.Visible = false;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CariMember(this.dataGridView1, edCari.Text);
        }

        public void disable()
        {
            dataGridView1.Enabled = false;
            edCari.Enabled = false;
            this.btnTambah.Enabled = false;
            this.btnUbah.Enabled = false;
        }

        public void enable()
        {
            dataGridView1.Enabled = true;
            this.btnTambah.Enabled = true;
            edCari.Enabled = true;
            this.btnUbah.Enabled = true;
            TampilMember(this.dataGridView1);
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows[0].Selected = true;
                txtID.Text = getKolom(dataGridView1, 0);
            }

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            uC_Member1.setFlag(1);
            uC_Member1.Visible = true;
            uC_Member1.btnTambah.Text = "Tambah";
            uC_Member1.dateTimePicker1.Visible = true;
            uC_Member1.label4.Visible = true;
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

        public void EnableEdit()
        {
            edCari.Enabled = true;
            dataGridView1.Enabled = true;
            this.btnTambah.Enabled = true;
            this.btnUbah.Enabled = true;

            TampilMember(this.dataGridView1);
            dataGridView1.Rows[int.Parse(txtRow.Text)].Selected = true;
            txtID.Text = getKolomEdit(dataGridView1, int.Parse(txtRow.Text));
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            uC_Member1.dateTimePicker1.Visible = false;
            uC_Member1.label4.Visible = false;

            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih pegawai terlebih dahulu");
                dataGridView1.Focus();
            }
            else
            {
                uC_Member1.setFlag(2);
                uC_Member1.btnTambah.Text = "Ubah";
                string nama = getKolom(dataGridView1, 1);
                string alamat = getKolom(dataGridView1, 2);
                string email = getKolom(dataGridView1, 3);
                uC_Member1.isiTextBox(nama, alamat, email, txtID.Text);
                uC_Member1.Visible = true;
                txtID.Clear();
                disable();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try{
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih data yang hendak dihapus");
                dataGridView1.Focus();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Apakah anda yakin menghapus data pegawai ini?", "Pertanyaan", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Mcontrol.HapusMember(int.Parse(txtID.Text));
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

        private void uC_Member1_Load(object sender, EventArgs e)
        {

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

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaksi utama = new Transaksi();
            utama.ShowDialog();
            this.Close();
        }

        private void presensiMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPresensiMember utama = new FormPresensiMember();
            utama.ShowDialog();
            this.Close();
        }

    }
}
