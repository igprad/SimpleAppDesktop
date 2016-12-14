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
    public partial class UC_Member : UserControl
    {
        MemberControl Mcontrol = new MemberControl();
        int flagperintah = 0;

        public void setFlag(int flag)
        {
            flagperintah = flag;
        }

        public UC_Member()
        {
            InitializeComponent();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            cleartxt();
            errorProvider1.Clear();
            this.Hide();
            FormMember myParent = (FormMember)this.Parent;
            myParent.enable();
        }

        private void UC_Member_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private bool cektxt() {
            bool temp = true;
            if (edNama.Text == "")
            {
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

            return temp;
        }

        private void cleartxt()
        {
            edNama.Clear();
            edAlamat.Clear();
            edEmail.Clear();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (flagperintah == 1)
                {

                    if (cektxt() == true)
                    {
                        errorProvider1.Clear();

                        //cekTanggalLahir tidak boleh kurang dari tanggal sekarang
                        if (dateTimePicker1.Value >= DateTime.Now)
                        {
                            MessageBox.Show("Maaf, tanggal lahir anda salah");
                            return;
                        }

                        if (Mcontrol.CekMemberUnik(edNama.Text, edAlamat.Text, edEmail.Text) != 0)
                        {
                            MessageBox.Show("Maaf, data sudah ada. " + Mcontrol.CekMemberUnik(edNama.Text, edAlamat.Text, edEmail.Text), "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        Mcontrol.EntryMember(edNama.Text, edEmail.Text, edAlamat.Text, dateTimePicker1.Value.ToString("dd/MM"),dateTimePicker1.Value.ToString("yy"));
                        if (Mcontrol.cekAdaTidakRecordMember(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString()) == 0)
                            Mcontrol.InsertRecordMemberBaru(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString(), Mcontrol.totalMemberAktif(), Mcontrol.totalMemberNonAktif(),
                                Mcontrol.totalMemberAktif() + Mcontrol.totalMemberNonAktif());
                        else
                            Mcontrol.TambahNonAktifMember(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
                        
                        cleartxt();
                        this.Hide();
                        FormMember myParent = (FormMember)this.Parent;
                        myParent.enable();
                    }
                }

                else
                {
                    
                    if (cektxt() == true)
                    {
                        errorProvider1.Clear();
                        
                        //if (Mcontrol.CekMemberUnik(edNama.Text, edAlamat.Text, edEmail.Text) > 1) // masih error, salah harusnya ga masuk sini saat edit
                        //{
                        //    MessageBox.Show("Maaf, data sudah ada. " + Mcontrol.CekMemberUnik(edNama.Text, edAlamat.Text, edEmail.Text), "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    return;
                        //}
                        DialogResult dr = MessageBox.Show("Apakah Anda yakin akan mengupdate pegawai ini ?", "Pertanyaan",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            Mcontrol.EditMember(edNama.Text, edAlamat.Text, edEmail.Text, int.Parse(txtID.Text));                            
                        }
                        cleartxt();
                        this.Hide();
                        FormMember myParent = (FormMember)this.Parent;
                        myParent.EnableEdit();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string temp_nama = "";
        public void isiTextBox( string nama, string alamat, string email, string id)
        {
            edNama.Text = nama;
            temp_nama = nama;
            edAlamat.Text = alamat;
            edEmail.Text = email;
            txtID.Text = id;
        }

        private void UC_Member_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void UC_Member_Click(object sender, EventArgs e)
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
