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
    public partial class UC_Jadwal : UserControl
    {
        JadwalControl Jcontrol = new JadwalControl();
        int flagperintah = 0;

        public void setFlag(int flag)
        {
            flagperintah = flag;
        }

        public UC_Jadwal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cleartxt();
            errorProvider1.Clear();
            this.Hide();
            FormPegawai myParent = (FormPegawai)this.Parent;
            myParent.enable();
        }

      
        private bool cektxt()
        {
            bool temp = true;
            
            return temp;
        }

        private void cleartxt()
        {
            
        }

        
        private void edNomor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      

        string temp_nama = "";
        public void isiTextBox(string pegawai, string kelas, string hari, string id)
        {
            temp_nama=pegawai;
            cmbPegawi.Text = pegawai;
            cmbKelas.Text = kelas;
            cmbHari.Text = hari;
            //dateTimePicker1.Text = masuk; Error karena data yang ditampilkan pada get data hanya menampilkan time
            //dateTimePicker2.Text = keluar;
            txtID.Text = id;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            cleartxt();
            errorProvider1.Clear();
            this.Hide();
            FormJadwal myParent = (FormJadwal)this.Parent;
            myParent.enable();
        }

        private void UC_Jadwal_Load(object sender, EventArgs e)
        {
            cmbPegawi.DataSource = Jcontrol.ListPegawai();
            cmbPegawi.DisplayMember = "nama_pegawai";


            cmbKelas.DataSource = Jcontrol.ListKelas();
            cmbKelas.DisplayMember = "nama_kelas";

            cmbHari.SelectedIndex = 0;
        }

        private string ubahHari(string hari) {
            if (hari == "Minggu") {
                hari = "0";
            }
            else if (hari == "Senin") {
                hari = "1";
            }

            else if (hari == "Selasa")
            {
                hari = "2";
            }

            else if (hari == "Rabu")
            {
                hari = "3";
            }

            else if (hari == "Kamis")
            {
                hari = "4";
            }

            else if (hari == "Jumat")
            {
                hari = "5";
            }

            else if (hari == "Sabtu")
            {
                hari = "6";
            }

            return hari;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try{
            if (flagperintah == 1)
            { //tambah data
                if (cektxt() == true)
                {
                    errorProvider1.Clear();

                    int idPegawai = Jcontrol.GetIdPegawaiByNama(cmbPegawi.Text);
                    int idKelas = Jcontrol.GetIdKelasByNama(cmbKelas.Text);
                    string hari = cmbHari.Text;
                    
                    JadwalEntity jadwal = new JadwalEntity(
                        idPegawai, idKelas, ubahHari(hari), dateTimePicker1.Value, dateTimePicker2.Value);
                    if (Jcontrol.cekUnikJadwal(jadwal) != 0)
                    {
                        MessageBox.Show("Maaf, data sudah ada.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dateTimePicker2.Value.TimeOfDay < dateTimePicker1.Value.TimeOfDay) {
                        MessageBox.Show("Maaf, jam yang anda masukkan tidak tepat", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (Jcontrol.cekJamJadwal(ubahHari(hari), dateTimePicker1.Value.TimeOfDay.ToString(), dateTimePicker2.Value.TimeOfDay.ToString()) > 0) {
                        MessageBox.Show("Maaf, jadwal sudah ada.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    cleartxt();
                    Jcontrol.EntryJadwal(jadwal);
                    this.Hide();
                    FormJadwal myParent = (FormJadwal)this.Parent;
                    myParent.enable();
                }
            }

            else
            {

                if (cektxt() == true)
                {
                    errorProvider1.Clear();
                    int idPegawai = Jcontrol.GetIdPegawaiByNama(cmbPegawi.Text);
                    int idKelas = Jcontrol.GetIdKelasByNama(cmbKelas.Text);
                    string hari = cmbHari.Text;
                    
                    JadwalEntity jadwal = new JadwalEntity(
                        idPegawai, idKelas, ubahHari(hari), dateTimePicker1.Value, dateTimePicker2.Value);
                    if (Jcontrol.cekUnikJadwal(jadwal) >= 1 )
                    {
                        MessageBox.Show("Maaf, data sudah ada.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dateTimePicker2.Value.TimeOfDay < dateTimePicker1.Value.TimeOfDay)
                    {
                        MessageBox.Show("Maaf, jam yang anda masukkan tidak tepat", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //if (Jcontrol.cekJamJadwal(ubahHari(hari), dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString()) > 0)
                    //{
                    //    MessageBox.Show("Maaf, jadwal sudah ada.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}

                    DialogResult dr = MessageBox.Show("Apakah Anda yakin akan mengupdate pegawai ini ?", "Pertanyaan",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Jcontrol.UbahJadwal(jadwal, int.Parse(txtID.Text));
                    }

                    cleartxt();
                    this.Hide();
                    FormJadwal myParent = (FormJadwal)this.Parent;
                    myParent.EnableEdit();
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
