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
    public partial class FormLogin : Form
    {
        string user, pass;int role;
        int last_id_lama, last_id_baru;
        public FormLogin()
        {
            InitializeComponent();
        }

        LoginControl lc = new LoginControl();
        JadwalControl JC = new JadwalControl();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user = edUser.Text;
            pass = edPass.Text;

            if (lc.cekLogin(user, pass) == true) {
                role = lc.getRoleUser(user, pass);
                last_id_lama = JC.LastIdBeforeUpdate();
                
                if (DateTime.Now.DayOfWeek.ToString() == 1.ToString()) {
                    JC.GenerateOneWeekJadwal();
                    last_id_baru = JC.LastIdBeforeUpdate();

                }

                if (role == 1)
                {
                    this.Hide();
                    FormPegawai utama = new FormPegawai();
                   // utama.setToolStripUser("Pengguna : Admin - " + user);
                    utama.ShowDialog();
                    this.Close();
                }

                else if (role == 2) {
                    this.Hide();
                    FormPresensiInstruktur utama = new FormPresensiInstruktur();
                    //utama.setToolStripUser("Pengguna : Manajer Operasional - " + user);
                    utama.ShowDialog();
                    this.Close();
                }

                else if (role == 3)
                {
                    this.Hide();
                    Transaksi utama = new Transaksi();
                    //utama.setToolStripUser("Pengguna : Kasir - " + user);
                    utama.Pegawai = lc.getIdPegawaiByIdLogin(lc.getIdByUsername(user));
                    utama.Nama_pegawai = lc.getNamaPegawai(lc.getIdByUsername(edUser.Text));
                    utama.ShowDialog();
                    this.Close();
                }

                else {
                    MessageBox.Show("Maaf user ini tidak memiliki hak untuk masuk ke sistem");
                }
                
            }

            else if(edUser.Text==""||edPass.Text==""){
                MessageBox.Show("Maaf, silahkan lengkapi data username dan password");
                if (edUser.Text == "")
                {
                    edUser.Text = "";
                    edUser.Focus();
                }
                else if (edPass.Text == "")
                {
                    edPass.Text = "";
                    edPass.Focus();
                }
            }

            else
            {
                MessageBox.Show("Maaf, username atau password salah");
                edUser.Text = "";
                edUser.Focus();
            }
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void edUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==39)
                e.Handled=true;
            if (e.KeyChar == 13)
                btnLogin_Click(sender, e);
        }

        private void edPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 39)
                e.Handled = true;
            if (e.KeyChar == 13)
                btnLogin_Click(sender, e);
        }

        private void edPass_Enter(object sender, EventArgs e)
        {
            edPass.Text = "";
        }

        private void edUser_Enter(object sender, EventArgs e)
        {
            edUser.Text = "";
        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
