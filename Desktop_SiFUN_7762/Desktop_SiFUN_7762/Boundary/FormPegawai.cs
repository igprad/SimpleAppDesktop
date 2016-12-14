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
    public partial class FormPegawai : Form
    {
        public FormPegawai()
        {
            InitializeComponent();
        }

        PegawaiControl Pcontrol = new PegawaiControl();

        public void TampilPegawai(DataGridView data) {
            data.DataSource = Pcontrol.TampilPegawai();

            DataTable DT = Pcontrol.TampilPegawai();
            BindingList<DataTable> listTbl = new BindingList<DataTable>();
            if (DT.Rows.Count > 0) {
                int counter = 0, subTblIndex = -1;
                foreach (DataRow dr in DT.Rows) {
                    if (counter == 0) {
                        listTbl.Add(DT.Clone());
                        subTblIndex++;
                    }
                    listTbl[subTblIndex].Rows.Add(dr.ItemArray);
                    counter++;
                    if (counter == 20) counter = 0;
                }
            }
            bindingSource1.DataSource = listTbl;
            bindingNavigator1.BindingSource = bindingSource1;
            data.DataSource = (DT.Rows.Count > 0 ? listTbl[bindingSource1.Position] : DT);
            data.Columns[0].HeaderText = "ID";
            data.Columns[0].Visible = false;
            data.Columns[1].HeaderText = "Nama";
            data.Columns[2].HeaderText = "Alamat";
            data.Columns[3].HeaderText = "Email";
            data.Columns[4].HeaderText = "No HP";
            data.Columns[5].HeaderText = "Jabatan";

            data.Columns[0].Width=50;
            data.Columns[1].Width=150;
            data.Columns[2].Width=200;
            data.Columns[3].Width=150;
            data.Columns[4].Width=130;
            data.Columns[5].Width =86;
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            TampilPegawai(this.dataGridView1);
            uC_Menu1.setFlag(1);
            uC_Menu1.Visible = false;
        }

        public void disable() {
            dataGridView1.Enabled = false;
            edCari.Enabled = false;
            this.btnTambah.Enabled = false;
            this.btnHapus.Enabled = false;
            this.btnUbah.Enabled = false;
        }

        public void enable() {
            dataGridView1.Enabled = true;
            this.btnTambah.Enabled = true;
            edCari.Enabled = true;
            this.btnHapus.Enabled = true;
            this.btnUbah.Enabled = true;
            TampilPegawai(this.dataGridView1);
            if (dataGridView1.RowCount > 0) {
                dataGridView1.Rows[0].Selected = true;
                txtID.Text = getKolom(dataGridView1, 0);
            }
            
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            uC_Menu1.Visible = true;
            uC_Menu1.btnTambah.Text = "Tambah";
            uC_Menu1.setFlag(1);
            disable();
        }

        private string getKolom(DataGridView dg, int i) {
            return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
        }

        private string getKolomEdit(DataGridView dg, int i) {
            return dg[dg.Columns[0].Index, dg.Rows[i].Index].Value.ToString();
        }

        private string getRow(DataGridView dg) {
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

        public void EnableEdit() {
            edCari.Enabled = true;
            dataGridView1.Enabled = true;
            btnTambah.Enabled = true;
            btnHapus.Enabled = true;
            btnUbah.Enabled = true;

            TampilPegawai(this.dataGridView1);
            dataGridView1.Rows[int.Parse(txtRow.Text)].Selected = true;
            txtID.Text = getKolomEdit(dataGridView1, int.Parse(txtRow.Text));
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih pegawai terlebih dahulu");
                dataGridView1.Focus();
            }
            else {
                uC_Menu1.setFlag(2);
                uC_Menu1.btnTambah.Text = "Ubah";
                string nama = getKolom(dataGridView1, 1);
                string alamat = getKolom(dataGridView1, 2);
                string email = getKolom(dataGridView1, 3);
                string no_hp = getKolom(dataGridView1, 4);
                string jabatan = getKolom(dataGridView1, 5);
                uC_Menu1.isiTextBox(jabatan, nama, alamat, email, no_hp, txtID.Text);
                uC_Menu1.Visible = true;
                txtID.Clear();
                disable();
            }
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
                    DialogResult dr = MessageBox.Show("Apakah anda yakin menghapus data pegawai ini?", "Pertanyaan", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            Pcontrol.HapusPegawai(int.Parse(txtID.Text));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Data Pegawai Masih digunakan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ex.ToString();
                        }
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
            if (dr == DialogResult.Yes) {
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

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            this.TampilPegawai(dataGridView1);
        }
    }
}
