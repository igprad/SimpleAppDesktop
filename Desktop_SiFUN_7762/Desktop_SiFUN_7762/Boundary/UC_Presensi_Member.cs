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
    public partial class UC_Presensi_Member : UserControl
    {
        PresensiControl con = new PresensiControl();
        JadwalControl jadwalController = new JadwalControl();

        int flagperintah = 0;

        public void setFlag(int flag)
        {
            flagperintah = flag;
        }

        public UC_Presensi_Member()
        {
            InitializeComponent();
        }

        private void UC_Presensi_Member_Load(object sender, EventArgs e)
        {
            cmbMember.DataSource = con.ListMember();
            cmbMember.DisplayMember = "no_member";
            cmbMember.ValueMember = "Id_member";
            tampilJadwalUpdate(dataGridView1);
        }

        public void tampilJadwalUpdate(DataGridView data) {
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
            FormPresensiMember myParent = (FormPresensiMember)this.Parent;
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
            cmbMember.SelectedIndex = -1;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
           string keterangan="";
            if (flagperintah == 1)
            { 
                if (cektxt() == true)
                {
                    errorProvider1.Clear();

                    //int IdMember = con.GetIdMemberByName(cmbMember.Text);
                    if (cmbJadwal.Text == "") {
                        MessageBox.Show("Maaf, harap lengkapi data terlebih dahulu");
                        return;
                    }

                    else if (cmbJadwal.Text != null)
                    {
                        if (cmbJadwal.Text == "Gym")
                        {
                            keterangan = "Mengikuti Jadwal : " + 13;
                        }
                        else
                            keterangan = "";// "Mengikuti Jadwal : " + cmbJadwal.SelectedValue.ToString();//con.GetIdJadwalByPresensiMember((int)DateTime.Now.DayOfWeek, con.GetIdKelas(cmbJadwal.Text));
                
                    }

                    if (con.CekPresensiInstruktur(int.Parse(cmbJadwal.Text)) <= 0) {
                        MessageBox.Show("Maaf, instruktur belum datang,harap presensi setelah instruktur datang. Terima Kasih");
                        return;
                    }

                    PresensiMemberEntity presmem = new PresensiMemberEntity(int.Parse(cmbMember.SelectedValue.ToString()), DateTime.Now, keterangan,int.Parse(cmbJadwal.Text.ToString()));
                    string id_jadwal = new String(keterangan.Where(Char.IsDigit).ToArray());
                    if (int.Parse(getKolom(dataGridView1,2)) != 13) {
                        if (con.CekJumlahMember(int.Parse(cmbJadwal.Text)) >= 25)
                        {
                            MessageBox.Show("Maaf, kuota member sudah penuh.", "kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (con.CekDepositPertemuanKosong(int.Parse(cmbMember.SelectedValue.ToString()), int.Parse(getKolom(dataGridView1,2))) > 0)
                        {
                            con.UpdateDepositPertemuan(int.Parse(cmbMember.SelectedValue.ToString()), int.Parse(getKolom(dataGridView1, 2)));
                        }
                        else
                        {
                            if (con.GetDepositUangByIdMember(int.Parse(cmbMember.SelectedValue.ToString())) > con.GetHargaKelasByIdMemberDanIdKelas(int.Parse(cmbJadwal.Text)))
                            {
                                con.KurangiDepositMember(int.Parse(cmbMember.SelectedValue.ToString()), decimal.Parse(con.GetHargaKelasByIdMemberDanIdKelas(int.Parse(cmbJadwal.Text)).ToString()));
                            }
                            else
                            {
                                MessageBox.Show("Maaf, deposit sudah habis", "kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        
                    }
                    con.EntryPresensiMember(presmem);

                    //DialogResult dr = MessageBox.Show("Apakah ingin cetak struk ?", "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //if (dr == DialogResult.Yes) {
                    //    PresensiMember form = new PresensiMember();
                    //    form.Show();
                    //}

                    cleartxt();
                    this.Hide();
                    FormPresensiMember myParent = (FormPresensiMember)this.Parent;
                    myParent.enable();
                }
            }
        }

        private void cmbJadwal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbJadwal.Text = getKolom(dataGridView1, 0);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbJadwal.Text = getKolom(dataGridView1, 0);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbJadwal.Text = getKolom(dataGridView1, 0);
        }

        //private void btnCek_Click(object sender, EventArgs e)
        //{
        //    if (cmbMember.Text != null)
        //    {
        //        cmbJadwal.DataSource = con.ListJadwalByMember(int.Parse(cmbMember.SelectedValue.ToString()));
        //        cmbJadwal.DisplayMember = "DataJadwal";
        //        cmbJadwal.ValueMember = "id_jadwal_update";
        //    }
        //    else {
        //        MessageBox.Show("Silahkan pilih member terlebih dahulu.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
