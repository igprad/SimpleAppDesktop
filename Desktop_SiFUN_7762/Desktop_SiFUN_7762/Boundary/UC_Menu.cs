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
    public partial class UC_Menu : UserControl
    {
        PegawaiControl Pcontrol = new PegawaiControl();
        int flagperintah = 0;

        public void setFlag(int flag) {
            flagperintah = flag;
        }

        public UC_Menu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private int CekDataDuplikasi(PegawaiEntity input) {
            return Pcontrol.CekDataDuplikasi(input);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cleartxt();
            errorProvider1.Clear();
            this.Hide();
            FormPegawai myParent = (FormPegawai)this.Parent;
            myParent.enable();
        }

        private void UC_Menu_Load(object sender, EventArgs e)
        {
            edNama.Focus();
            cmbJabatan.DataSource = Pcontrol.getRole();
            cmbJabatan.DisplayMember = "nama_role";
            
        }

        private bool cektxt() {
            bool temp = true;
            if (edNama.Text == "") {
                errorProvider1.SetError(edNama, "Silahkan isi Nama Pegawai");
                edNama.Focus();
                temp = false;
            }
            if (edAlamat.Text == "")
            {
                errorProvider1.SetError(edAlamat, "Silahkan isi Alamat Rumah Pegawai");
                edAlamat.Focus();
                temp = false;
            }

            if (!edEmail.Text.Contains('@') || (!edEmail.Text.Contains(".com") && !edEmail.Text.Contains(".co.id") && !edEmail.Text.Contains(".ac.id")))
            {
                errorProvider1.SetError(edEmail, "Format Email Salah");
                edEmail.Focus();
                temp = false;
            }

            if (edEmail.Text == "")
            {
                errorProvider1.SetError(edEmail, "Silahkan isi Email Pegawai");
                edEmail.Focus();
                temp = false;
            }
            if (edNomor.Text == "")
            {
                errorProvider1.SetError(edNomor, "Silahkan isi Nomor Handphone Pegawai");
                edNomor.Focus();
                temp = false;
            }

            if (cmbJabatan.SelectedIndex == -1) {
                errorProvider1.SetError(cmbJabatan, "Silahkan Pilih Jabatan/Role Pegawai");
                cmbJabatan.Focus();
                temp = false;
            }


            return temp;
        }

        private void cleartxt() {
            edNama.Clear();
            edAlamat.Clear();
            edEmail.Clear();
            edNomor.Clear();
            cmbJabatan.SelectedIndex = -1;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try{
            if (flagperintah == 1)
            { 
                if (cektxt() == true)
                {
                    errorProvider1.Clear();
                    
                    int IDRole = Pcontrol.getIDRole(cmbJabatan.Text);
                    int idLast = Pcontrol.getLastIdPegawai() + 1;
                    if (IDRole == 4)
                    {
                        Pcontrol.EntryUserPegawai(IDRole, "Ins" + idLast, "123456");
                    }
                    else
                    {
                        Pcontrol.EntryUserPegawai(IDRole, "Pegawai" + idLast, "123456");
                    }
                    PegawaiEntity pegawai = new PegawaiEntity(IDRole, edNama.Text, edAlamat.Text, edEmail.Text, edNomor.Text,Pcontrol.getLastIdLogin());
                    if (Pcontrol.CekDataDuplikasi(pegawai) != 0)
                    {
                        MessageBox.Show("Maaf, data sudah ada."+Pcontrol.CekDataDuplikasi(pegawai), "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Pcontrol.EntryPegawai(pegawai);
                    cleartxt();
                    this.Hide();
                    FormPegawai myParent = (FormPegawai)this.Parent;
                    myParent.enable();
                }
            }

            else
            {
                
                if (cektxt() == true) {
                    errorProvider1.Clear();
                    
                    int IDRole = Pcontrol.getIDRole(cmbJabatan.Text);
                    PegawaiEntity pegawai = new PegawaiEntity(IDRole, edNama.Text, edAlamat.Text, edEmail.Text, edNomor.Text);
                    //if (Pcontrol.CekDataDuplikasi(pegawai) > 1) //Masih error code pengecekan ini
                    //{
                    //    MessageBox.Show("Maaf, data sudah ada." + Pcontrol.CekDataDuplikasi(pegawai), "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}
                    DialogResult dr = MessageBox.Show("Apakah Anda yakin akan mengupdate pegawai ini ?", "Pertanyaan",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes) {
                        Pcontrol.EditPegawai(pegawai, int.Parse(txtID.Text));
                    }
                    cleartxt();
                    this.Hide();
                    FormPegawai myParent = (FormPegawai)this.Parent;
                    myParent.EnableEdit();
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edNomor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void edEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        string temp_nama = "";
        public void isiTextBox(string jabatan, string nama, string alamat, string email, string hp,string id) {
            edNama.Text = nama;
            temp_nama = nama;
            edAlamat.Text = alamat;
            edEmail.Text = email;
            edNomor.Text = hp;
            cmbJabatan.Text = jabatan;
            txtID.Text = id;
        }
    }
}
