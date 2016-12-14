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
    public partial class FormPromo : Form
    {
        public FormPromo()
        {
            InitializeComponent();
        }

        PromoControl ProControl = new PromoControl();

        public void TampilPromo(DataGridView data) {
            data.DataSource = ProControl.TampilPromo();
            DataTable DT = ProControl.TampilPromo();
            BindingList<DataTable> listTbl = new BindingList<DataTable>();
            if (DT.Rows.Count > 0)
            {
                int counter = 0, subTblIndex = -1;
                foreach (DataRow dr in DT.Rows)
                {
                    if (counter == 0)
                    {
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
            data.Columns["ID_PROMO"].Visible = false;
            data.Columns["NAMA_PROMO"].HeaderText = "Promo";
            data.Columns[1].HeaderText = "Jenis";
            data.Columns[2].HeaderText = "Harga";
            data.Columns[3].HeaderText = "Keterangan";

            data.Columns[4].DisplayIndex = 1;
            data.Columns[1].DisplayIndex = 4;
            data.Columns[0].Width = 50;
            data.Columns[1].Width = 150;
            data.Columns[2].Width = 150;
            data.Columns[3].Width = 220;
            data.Columns[4].Width = 200;

        }

        private void FormPromo_Load(object sender, EventArgs e)
        {
            TampilPromo(this.dataGridView1);
            uC_Promo1.setFlag(1);
            uC_Promo1.Visible = false;
        }

        public void disable()
        {
            dataGridView1.Enabled = false;
            this.btnTambah.Enabled = false;
            this.btnUbah.Enabled = false;
        }

        public void enable()
        {
            dataGridView1.Enabled = true;
            this.btnTambah.Enabled = true;
            this.btnUbah.Enabled = true;
            TampilPromo(this.dataGridView1);
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows[0].Selected = true;
                txtID.Text = getKolom(dataGridView1, 0);
            }

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            uC_Promo1.Visible = true;
            uC_Promo1.btnTambah.Text = "Tambah";
            uC_Promo1.setFlag(1);
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
            dataGridView1.Enabled = true;
            btnTambah.Enabled = true;
          
            btnUbah.Enabled = true;

            TampilPromo(this.dataGridView1);
            dataGridView1.Rows[int.Parse(txtRow.Text)].Selected = true;
            txtID.Text = getKolomEdit(dataGridView1, int.Parse(txtRow.Text));
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih promo terlebih dahulu");
                dataGridView1.Focus();
            }
            else
            {
                uC_Promo1.setFlag(2);
                uC_Promo1.btnTambah.Text = "Ubah";
                string nama = getKolom(dataGridView1, 4);
                string harga = getKolom(dataGridView1, 2);
                string keterangan = getKolom(dataGridView1, 3);
                uC_Promo1.isiTextBox(nama,harga,keterangan,txtID.Text);
                uC_Promo1.Visible = true;
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

        private void bindingSource1_PositionChanged(object sender, EventArgs e)
        {
            this.TampilPromo(dataGridView1);
        }
    }
}
