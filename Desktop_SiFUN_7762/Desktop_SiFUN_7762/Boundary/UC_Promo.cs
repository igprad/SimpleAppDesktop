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
    public partial class UC_Promo : UserControl
    {
        PromoControl ProControl = new PromoControl();
        int flagperintah = 0;

        public void setFlag(int flag)
        {
            flagperintah = flag;
        }

        public UC_Promo()
        {
            InitializeComponent();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            cleartxt();
            errorProvider1.Clear();
            this.Hide();
            FormPromo myParent = (FormPromo)this.Parent;
            myParent.enable();
        }

        private bool cektxt()
        {
            bool temp = true;
            if (edPromo.Text == "")
            {
                errorProvider1.SetError(edPromo, "Silahkan isi Nama Promo");
                edPromo.Focus();
                temp = false;
            }
            if (edHarga.Text == "")
            {
                errorProvider1.SetError(edHarga, "Silahkan isi Harga");
                edPromo.Focus();
                temp = false;
            }
            return temp;
        }

        private void cleartxt()
        {
            edPromo.Clear();
            edHarga.Clear();
            edKeterangan.Clear();
        }

        string temp_nama = "";
        public void isiTextBox(string nama, string harga, string keterangan,string id)
        {
            temp_nama = nama;
            edPromo.Text = nama;
            edHarga.Text = harga;
            edKeterangan.Text = keterangan;
            txtID.Text = id;
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
                        PromoEntity promo = new PromoEntity(comboBox1.SelectedItem.ToString(), (decimal)double.Parse(edHarga.Text), edKeterangan.Text,edPromo.Text);
                        if (ProControl.CekPromoUnik(promo.Jenis_promo) != 0)
                        {
                            MessageBox.Show("Maaf, data sudah ada " + ProControl.CekPromoUnik(promo.Jenis_promo), "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        ProControl.EntriPromo(promo.Jenis_promo, promo.Harga, promo.Keterangan,promo.Nama);
                        cleartxt();
                        this.Hide();
                        FormPromo myParent = (FormPromo)this.Parent;
                        myParent.enable();
                    }
                }

                else
                {

                    if (cektxt() == true)
                    {
                        errorProvider1.Clear();
                        PromoEntity promo = new PromoEntity(comboBox1.SelectedItem.ToString(), (decimal)double.Parse(edHarga.Text), edKeterangan.Text,edPromo.Text);
                        if (ProControl.CekPromoUnik(promo.Jenis_promo) > 1)
                        {
                            MessageBox.Show("Maaf, data sudah ada " + ProControl.CekPromoUnik(promo.Jenis_promo), "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        DialogResult dr = MessageBox.Show("Apakah Anda yakin akan mengupdate pegawai ini ?", "Pertanyaan",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            ProControl.EditPromo(promo.Jenis_promo, promo.Harga, promo.Keterangan, int.Parse(txtID.Text),promo.Nama);
                        }
                        cleartxt();
                        this.Hide();
                        FormPromo myParent = (FormPromo)this.Parent;
                        myParent.EnableEdit();
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
