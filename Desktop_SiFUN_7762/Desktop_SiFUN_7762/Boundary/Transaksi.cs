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
    public partial class Transaksi : Form
    {
        private static int pegawai;

        public int Pegawai
        {
            get { return pegawai; }
            set { pegawai = value; }
        }

        private string nama = "", harga = "", no_struk = "", tanggal = "", kasir = "", masa_aktif = "", kelas = "",id_member="",promo="";
        private int jum_deposit_senam = 0;
        private static string nama_pegawai = "";
        private string id="", row="";

        public string Nama_pegawai
        {
            get { return nama_pegawai; }
            set { nama_pegawai = value; }
        }
        string tempIdMember="";
        TransaksiControl con = new TransaksiControl();
        MemberControl Mcontrol = new MemberControl();

        public Transaksi()
        {
            InitializeComponent();
        }

        private void presensiMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPresensiMember utama = new FormPresensiMember();
            utama.ShowDialog();
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
            Application.Exit();
        }

        private void SetDataTransaksi() {
            try
            {
                dataGridView1.DataSource = con.GetDataTransaksiByDate(dateTimePicker1.Text.ToString());
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns["id_promo"].Visible = false;
                dataGridView1.Columns["id_kelas"].Visible = false;
                dataGridView1.Columns["id_Member"].Visible = false;
                dataGridView1.Columns["id_pegawai"].Visible = false;
                dataGridView1.Columns["ID_MEMBER"].Width = 100;
                dataGridView1.Columns["NAMA_KELAS"].Width = 100;
                dataGridView1.Columns["TGL_TRANSAKSI"].Width = 150;
                dataGridView1.Columns["BIAYA"].Width = 150;
                dataGridView1.Columns["JENIS_PROMO"].Width = 150;
                dataGridView1.Columns["NO_MEMBER"].Width = 150;
                dataGridView1.Columns["NAMA_PEGAWAI"].Width = 150;
                dataGridView1.Columns["NO_MEMBER"].DisplayIndex = 0;

            }
            catch (Exception ex) {
                MessageBox.Show(this, "Maaf data tidak ditemukan : ");
                ex.ToString();
            }
        }

        private void SetDataPromo() {
            dataGridView1.DataSource = con.GetDataPromo();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Promo";
            dataGridView1.Columns[2].HeaderText = "Harga";
            dataGridView1.Columns[3].HeaderText = "Keterangan";
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 220;
        }


        private void SetCmbPromo() {
            cmbPromo.DataSource = con.GetDataPromo();
            cmbPromo.DisplayMember = "NAMA_PROMO";
            cmbPromo.ValueMember = "ID_PROMO";
        }

        private void SetCmbMember() {

            AutoCompleteStringCollection no_member = new AutoCompleteStringCollection();

            cmbMember.DataSource = con.GetMember();
            cmbMember.DisplayMember = "NO_MEMBER";
            cmbMember.ValueMember = "ID_MEMBER";

            cmbIdMember2.DataSource = con.GetMember();
            cmbIdMember2.DisplayMember = "NO_MEMBER";
            cmbIdMember2.ValueMember = "ID_MEMBER";

            for (int i = 0; i < cmbMember.Items.Count; i++) {
                no_member.Add(cmbMember.GetItemText(cmbMember.Items[i]));
            }
            cmbMember.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMember.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbIdMember2.AutoCompleteMode = AutoCompleteMode.Append;
            cmbIdMember2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbMember.AutoCompleteCustomSource = no_member;
            cmbIdMember2.AutoCompleteCustomSource = no_member;
        }

        private void SetCmbKelas() {
            cmbKelas.DataSource = con.GetDataKelas();
            cmbKelas.DisplayMember = "NAMA_KELAS";
            cmbKelas.ValueMember = "ID_KELAS";
        }

        private void setDepositPertemuan(bool input) {
            gb_deposit.Visible = input;
           
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            label1.Text = nama_pegawai;
            setDepositPertemuan(false);
            SetDataTransaksi();
            SetCmbKelas();
            SetCmbPromo();
            SetCmbMember();
            clear();
            setTambahanAktivasiGetMember(false);
            setTambahanDeposit(false);
            cmbKelas.Visible = false;
            
        }

        private void setTambahanDeposit(bool input) {
            lblDeposit.Visible = input;
            txtDeposit.Visible = input;
        }

        private void setKelas(bool input) {
            lblIdKelas.Visible = input;
            cmbKelas.Visible = input;
           
        }

        private void setTambahanAktivasiGetMember(bool input) {
            cmbIdMember2.Visible = input;
            txtNamaMember2.Visible = input;
            lblIdMember2.Visible = input;
            lblNama2.Visible = input;
            lblIdKelas.Visible = input;

        }

        private void cmbPromo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(cmbPromo.SelectedValue.ToString()) > 0 && int.Parse(cmbPromo.SelectedValue.ToString()) < 5)
                {
                    if (int.Parse(cmbPromo.SelectedValue.ToString()) == 4 || int.Parse(cmbPromo.SelectedValue.ToString()) == 3)
                    {
                        setTambahanAktivasiGetMember(true);
                    }
                    else {
                        setTambahanAktivasiGetMember(false);
                    }
                    setTambahanDeposit(false);
                    setKelas(false);
                    setDepositPertemuan(false);
                    cmbMember.DataSource = con.GetMember();
                    cmbIdMember2.DataSource = con.GetMember();
                    txtTotalHarga.Text = con.GetHargaPromo(int.Parse(cmbPromo.SelectedValue.ToString())).ToString();
                }
                else if (int.Parse(cmbPromo.SelectedValue.ToString()) > 4 && int.Parse(cmbPromo.SelectedValue.ToString()) < 9)
                {
                    setTambahanAktivasiGetMember(false);
                    setTambahanDeposit(false);
                    setKelas(true);
                    cmbMember.DataSource = con.GetMember();
                    cmbIdMember2.DataSource = con.GetMember();
                    setDepositPertemuan(true);
                    string output = new string(cmbPromo.Text.ToCharArray().Where(c => char.IsDigit(c)).ToArray());
                    jum_deposit_senam = int.Parse(output);
                    txtDepositPertemuan.Text = ((int)con.GetHargaPromo(int.Parse(cmbPromo.SelectedValue.ToString()))).ToString();
                    
                }
                else if (int.Parse(cmbPromo.SelectedValue.ToString()) == 9 )
                {
                    setTambahanAktivasiGetMember(false);
                    setTambahanDeposit(true);
                    setKelas(false);
                    cmbMember.DataSource = con.GetMember();
                    cmbIdMember2.DataSource = con.GetMember();
                    setDepositPertemuan(false);
                }

                
                
            }
            catch (Exception ex) { ex.ToString(); }
        }

        private void cmbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbMember.SelectedValue.ToString() != "")
                    txtNamaMember.Text = con.GetNamaMemberById(int.Parse(cmbMember.SelectedValue.ToString()));
            }
            catch (Exception ex) { ex.ToString(); }

            tempIdMember = cmbMember.Text;
        }

        private void cmbKelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbKelas.Text != null)
                {
                    txtTotalHarga.Text = (con.GetHargaKelasSenam(int.Parse(cmbKelas.SelectedValue.ToString()))*jum_deposit_senam).ToString();
                }
            }
            catch (Exception ex) { ex.ToString(); }
        }

        private void cmbIdMember2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbIdMember2.SelectedValue.ToString() != null)
                    txtNamaMember2.Text = con.GetNamaMemberById(int.Parse(cmbIdMember2.SelectedValue.ToString()));


                if (cmbIdMember2.SelectedValue.ToString() == cmbMember.SelectedValue.ToString() && cmbIdMember2.SelectedIndex != -1 && (cmbPromo.SelectedValue.ToString() == "4" || cmbPromo.SelectedValue.ToString() == "3"))
                {
                    MessageBox.Show(this, "Maaf, id member yang mengajak tidak boleh sama", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbIdMember2.SelectedIndex = -1;
                    txtNamaMember2.Text = "";
                }
                else if (cmbMember.SelectedValue.ToString() == "")
                {
                    MessageBox.Show(this, "Maaf, id member utama harap dipilih terlebih dahulu", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbIdMember2.SelectedIndex = -1;
                    txtNamaMember2.Text = "";
                }
            }
            catch (Exception ex) { ex.ToString(); }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear() {
            cmbIdMember2.SelectedIndex = -1;
            cmbMember.SelectedIndex = -1;
            cmbKelas.SelectedIndex = -1;
            cmbPromo.SelectedIndex = -1;
            txtNamaMember.Text = "";
            txtNamaMember2.Text = "";
            txtTotalHarga.Text = "0";
            txtDeposit.Text = "";
            setDepositPertemuan(false);
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbPromo.SelectedValue.ToString() == "9")
                    {
                        if(!con.IsActiveMember(int.Parse(cmbMember.SelectedValue.ToString()))){
                            MessageBox.Show(this, "Maaf, Member ini belum aktif", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        
                        if (txtDeposit.Text == "")
                        {
                            MessageBox.Show(this, "Maaf, Harap isikan Data terlebih dahulu.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                        else if(con.GetDepositByIDMember(int.Parse(cmbMember.SelectedValue.ToString()))<(decimal)300000 && double.Parse(txtDeposit.Text)<300000)
                        {
                            MessageBox.Show(this, "Maaf, Deposit anda kurang dari  Rp 300.000, silahkan deposit minimal Rp 300.000", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                      
                        else
                        {
                            con.TambahTransaksi(int.Parse(cmbPromo.SelectedValue.ToString()), int.Parse(cmbMember.SelectedValue.ToString()),
                                null, DateTime.Now, decimal.Parse(txtDeposit.Text),Pegawai);
                            con.DepositReguler(int.Parse(cmbMember.SelectedValue.ToString()), decimal.Parse(txtDeposit.Text));
                            CetakStrukTransaksi cetak = new CetakStrukTransaksi();
                            try
                            {
                                no_struk = DateTime.Now.ToString("yy") + "." + DateTime.Now.ToString("MM") + "." + con.GetLastIdTransaksi();
                                cetak.InputCetakStruk(cmbMember.Text, txtNamaMember.Text, txtTotalHarga.Text, no_struk, DateTime.Now.ToString(), nama_pegawai, con.GetTglExpired(int.Parse(cmbMember.SelectedValue.ToString())).ToString(), "", cmbPromo.Text, "","");
                                cetak.setListBox(kelas);
                            }
                            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                            cetak.ShowDialog();
                            MessageBox.Show(this, "Data Transaksi Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    else if (cmbPromo.SelectedValue.ToString() == "4")//member get member
                    {
                        //cek member aktif blm
                        
                        if(con.IsActiveMember(int.Parse(cmbMember.SelectedValue.ToString())))
                        {
                            MessageBox.Show(this,"Member tersebut sudah aktif");
                            return;
                        }
                         else if (con.IsActiveMember(int.Parse(cmbIdMember2.SelectedValue.ToString()))) { 
                             MessageBox.Show(this,"Member "+int.Parse(cmbIdMember2.SelectedValue.ToString())+"sudah aktif");
                            return;
                     }
                        con.TambahTransaksi(int.Parse(cmbPromo.SelectedValue.ToString()), int.Parse(cmbMember.SelectedValue.ToString()),
                            null, DateTime.Now, con.GetHargaPromo(int.Parse(cmbPromo.SelectedValue.ToString())), Pegawai);
                        CetakStrukTransaksi cetak = new CetakStrukTransaksi();
                        try
                        {
                            no_struk = DateTime.Now.ToString("yy") + "." + DateTime.Now.ToString("MM") + "." + con.GetLastIdTransaksi();
                            cetak.InputCetakStruk(cmbMember.Text, txtNamaMember.Text, txtTotalHarga.Text, no_struk, DateTime.Now.ToString(), nama_pegawai, con.GetTglExpired(int.Parse(cmbMember.SelectedValue.ToString())).ToString(), "", cmbPromo.Text, cmbIdMember2.Text, txtNamaMember2.Text);
                            cetak.setListBoxSetelahTransaksi(kelas);
                        }
                        catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                        cetak.ShowDialog();
                        con.AktivasiTahunanMemberGetMember(int.Parse(cmbIdMember2.SelectedValue.ToString()), int.Parse(cmbMember.SelectedValue.ToString()));
                        if (Mcontrol.cekAdaTidakRecordMember(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString()) == 0)
                            Mcontrol.InsertRecordMemberBaru(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString(), Mcontrol.totalMemberAktif(), Mcontrol.totalMemberNonAktif(),
                                Mcontrol.totalMemberAktif() + Mcontrol.totalMemberNonAktif());
                        Mcontrol.UbahAktifMember(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
                        MessageBox.Show(this, "Data Transaksi Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                else if (cmbPromo.SelectedValue.ToString() == "3") //couple aktivasi
                {
                     if(con.IsActiveMember(int.Parse(cmbMember.SelectedValue.ToString())))
                        {
                            MessageBox.Show(this,"Member "+cmbMember.Text+" sudah aktif");
                            return;
                        }
                     else if (con.IsActiveMember(int.Parse(cmbIdMember2.SelectedValue.ToString()))) { 
                             MessageBox.Show(this,"Member "+cmbIdMember2+" sudah aktif");
                            return;
                     }
                    con.TambahTransaksi(int.Parse(cmbPromo.SelectedValue.ToString()), int.Parse(cmbMember.SelectedValue.ToString()),
                        null, DateTime.Now, con.GetHargaPromo(int.Parse(cmbPromo.SelectedValue.ToString())) / 2, Pegawai);
                    CetakStrukTransaksi cetak = new CetakStrukTransaksi();
                    try
                    {
                        no_struk = DateTime.Now.ToString("yy") + "." + DateTime.Now.ToString("MM") + "." + con.GetLastIdTransaksi();
                        cetak.InputCetakStruk(cmbMember.Text, txtNamaMember.Text, (double.Parse(txtTotalHarga.Text) / 2).ToString(), no_struk, DateTime.Now.ToString(), nama_pegawai, con.GetTglExpired(int.Parse(cmbMember.SelectedValue.ToString())).ToString(), "", cmbPromo.Text, "", "");
                        cetak.setListBoxSetelahTransaksi(kelas);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    
                    con.TambahTransaksi(int.Parse(cmbPromo.SelectedValue.ToString()), int.Parse(cmbIdMember2.SelectedValue.ToString()),
                        null, DateTime.Now, con.GetHargaPromo(int.Parse(cmbPromo.SelectedValue.ToString())) / 2, Pegawai);
                    
                    try
                    {
                        no_struk = DateTime.Now.ToString("yy") + "." + DateTime.Now.ToString("MM") + "." + con.GetLastIdTransaksi();
                        cetak.InputCetakStruk(cmbIdMember2.Text, txtNamaMember2.Text, (double.Parse(txtTotalHarga.Text)/2).ToString(), no_struk, DateTime.Now.ToString(), nama_pegawai, con.GetTglExpired(int.Parse(cmbIdMember2.SelectedValue.ToString())).ToString(), "", cmbPromo.Text, "", "");
                        cetak.setListBox(kelas);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    cetak.ShowDialog();
                    con.AktivasiCouple(int.Parse(cmbMember.SelectedValue.ToString()), int.Parse(cmbIdMember2.SelectedValue.ToString()));
                    if (Mcontrol.cekAdaTidakRecordMember(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString()) == 0)
                        Mcontrol.InsertRecordMemberBaru(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString(), Mcontrol.totalMemberAktif(), Mcontrol.totalMemberNonAktif(),
                            Mcontrol.totalMemberAktif() + Mcontrol.totalMemberNonAktif());
                    Mcontrol.UbahAktifMember(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
                    Mcontrol.UbahAktifMember(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
                    MessageBox.Show(this, "Data Transaksi Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (cmbPromo.SelectedValue.ToString() == "1")
                {
                    if (con.IsActiveMember(int.Parse(cmbMember.SelectedValue.ToString())))
                    {
                        MessageBox.Show(this, "Member "+cmbMember.Text+" tersebut sudah aktif");
                        return;
                    }
                    con.TambahTransaksi(int.Parse(cmbPromo.SelectedValue.ToString()), int.Parse(cmbMember.SelectedValue.ToString()),
                        null, DateTime.Now, con.GetHargaPromo(int.Parse(cmbPromo.SelectedValue.ToString())), Pegawai);
                    CetakStrukTransaksi cetak = new CetakStrukTransaksi();
                    try
                    {
                        no_struk = DateTime.Now.ToString("yy") + "." + DateTime.Now.ToString("MM") + "." + con.GetLastIdTransaksi();
                        cetak.InputCetakStruk(cmbMember.Text, txtNamaMember.Text, txtTotalHarga.Text, no_struk, DateTime.Now.ToString(), nama_pegawai, con.GetTglExpired(int.Parse(cmbMember.SelectedValue.ToString())).ToString(), "", cmbPromo.Text, "", "");
                        cetak.setListBox(kelas);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                    cetak.ShowDialog();
                    con.AktivasiReguler(int.Parse(cmbMember.SelectedValue.ToString()));
                    if (Mcontrol.cekAdaTidakRecordMember(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString()) == 0)
                        Mcontrol.InsertRecordMemberBaru(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString(), Mcontrol.totalMemberAktif(), Mcontrol.totalMemberNonAktif(),
                            Mcontrol.totalMemberAktif() + Mcontrol.totalMemberNonAktif());
                    Mcontrol.UbahAktifMember(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
                    MessageBox.Show(this, "Data Transaksi Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if ((cmbMember.SelectedIndex == -1) && cmbPromo.SelectedIndex == -1)
                {
                    MessageBox.Show(this, "Maaf, Harap isikan Data terlebih dahulu.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (!con.IsActiveMember(int.Parse(cmbMember.SelectedValue.ToString())))
                    {
                        MessageBox.Show(this, "Member " + cmbMember.Text + " tersebut belum aktif");
                        return;
                    }
                    else {
                        if (con.GetDepositByIDMember(int.Parse(cmbMember.SelectedValue.ToString()))- decimal.Parse(txtTotalHarga.Text)<300000)
                        {
                            MessageBox.Show(this, "Member ini tidak memiliki cukup deposit uang, jika deposit dilakukan");
                            return;
                        }

                        if (con.GetDepositByIDMember(int.Parse(cmbMember.SelectedValue.ToString())) < decimal.Parse(txtTotalHarga.Text))
                        {
                            MessageBox.Show(this, "Member ini tidak memiliki cukup deposit uang");
                            return;
                        }

                        if (!con.IsDepositMemberExist(int.Parse(cmbMember.SelectedValue.ToString()), int.Parse(cmbKelas.SelectedValue.ToString())))
                        {
                            MessageBox.Show("Data Deposit Belum Ada, Data deposit baru akan di daftarkan");
                            con.TambahTransaksi(int.Parse(cmbPromo.SelectedValue.ToString()), int.Parse(cmbMember.SelectedValue.ToString()),
                            int.Parse(cmbKelas.SelectedValue.ToString()), DateTime.Now, decimal.Parse(txtTotalHarga.Text), Pegawai);
                            con.DepositReguler(int.Parse(cmbMember.SelectedValue.ToString()), -decimal.Parse(txtTotalHarga.Text));
                            con.TambahDepositKelas(int.Parse(cmbMember.SelectedValue.ToString()), int.Parse(cmbKelas.SelectedValue.ToString()), int.Parse(txtDepositPertemuan.Text), null);
                            MessageBox.Show(this, "Data Transaksi Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SetDataTransaksi();
                            CetakStrukTransaksi cetak = new CetakStrukTransaksi();
                            try
                            {
                                no_struk = DateTime.Now.ToString("yy") + "." + DateTime.Now.ToString("MM") + "." + con.GetLastIdTransaksi();
                                cetak.InputCetakStruk(cmbMember.Text, txtNamaMember.Text, txtTotalHarga.Text, no_struk, DateTime.Now.ToString(), nama_pegawai, con.GetTglExpired(int.Parse(cmbMember.SelectedValue.ToString())).ToString(), cmbKelas.Text, cmbPromo.Text, "", "");
                                cetak.setListBox(kelas);
                            }
                            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                            cetak.ShowDialog();
                        }

                        else if (con.IsDepositMemberExist(int.Parse(cmbMember.SelectedValue.ToString()), int.Parse(cmbKelas.SelectedValue.ToString())))
                        {
                            MessageBox.Show("Data Deposit Sudah Ada, Data deposit akan di update");
                            con.TambahTransaksi(int.Parse(cmbPromo.SelectedValue.ToString()), int.Parse(cmbMember.SelectedValue.ToString()),
                            int.Parse(cmbKelas.SelectedValue.ToString()), DateTime.Now, decimal.Parse(txtTotalHarga.Text), Pegawai);
                            con.UpdateDepositKelas(int.Parse(cmbMember.SelectedValue.ToString()), int.Parse(cmbKelas.SelectedValue.ToString()), int.Parse(txtDepositPertemuan.Text));
                            con.DepositReguler(int.Parse(cmbMember.SelectedValue.ToString()), -decimal.Parse(txtTotalHarga.Text));
                            MessageBox.Show(this, "Data Transaksi Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SetDataTransaksi();
                            CetakStrukTransaksi cetak = new CetakStrukTransaksi();
                            try
                            {
                                no_struk = DateTime.Now.ToString("yy") + "." + DateTime.Now.ToString("MM") + "." + con.GetLastIdTransaksi();
                                cetak.InputCetakStruk(cmbMember.Text, txtNamaMember.Text, txtTotalHarga.Text, no_struk, DateTime.Now.ToString(), nama_pegawai, con.GetTglExpired(int.Parse(cmbMember.SelectedValue.ToString())).ToString(), cmbKelas.Text, cmbPromo.Text, "","");
                                cetak.setListBox(kelas);
                            }
                            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                            cetak.ShowDialog();
                        }
                        
                    }
                   
                }

                clear();
                SetDataTransaksi();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        private void txtDeposit_TextChanged(object sender, EventArgs e)
        {
            txtTotalHarga.Text = txtDeposit.Text;
        }

        private void registerMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMember utama = new FormMember();
            utama.Pegawai = "Kasir";
            utama.ShowDialog();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SetDataTransaksi();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (this.id == "") {
                MessageBox.Show(this, "Maaf silahkan pilih data terlebih dahulu");
                return;
            }
            CetakStrukTransaksi cetak = new CetakStrukTransaksi();
            
            try
            {
                
                cetak.InputCetakStruk(id_member, nama, harga,no_struk, tanggal, kasir, masa_aktif, kelas,promo,"","");
                cetak.setListBox(kelas);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            cetak.ShowDialog();
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            id = getKolom(dataGridView1, 0);
            id_member = getKolom(dataGridView1, 9);
            promo = getKolom(dataGridView1,8);
            nama = con.GetNamaMemberById(int.Parse(getKolom(dataGridView1, 2)));
            harga = getKolom(dataGridView1, 5);
            no_struk = DateTime.Now.ToString("yy") + "." + DateTime.Now.ToString("MM") + "." + id;
            tanggal = DateTime.Now.ToString();
            kasir = getKolom(dataGridView1, 10);
            masa_aktif = con.GetTglExpired(int.Parse(getKolom(dataGridView1, 2))).ToString();
            kelas = getKolom(dataGridView1, 7);
            row = getRow(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = getKolom(dataGridView1, 0);
            id_member = getKolom(dataGridView1, 9);
            promo = getKolom(dataGridView1, 8);
            nama = con.GetNamaMemberById(int.Parse(getKolom(dataGridView1, 2)));
            harga = getKolom(dataGridView1, 5);
            no_struk = DateTime.Now.ToString("yy") + "." + DateTime.Now.ToString("MM") + "." + id;
            tanggal = DateTime.Now.ToString();
            kasir = getKolom(dataGridView1, 10);
            masa_aktif = con.GetTglExpired(int.Parse(getKolom(dataGridView1, 2))).ToString();
            kelas = getKolom(dataGridView1, 7);
            row = getRow(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = getKolom(dataGridView1, 0);
            id_member = getKolom(dataGridView1, 9);
            promo = getKolom(dataGridView1, 8);
            nama = con.GetNamaMemberById(int.Parse(getKolom(dataGridView1, 2)));
            harga = getKolom(dataGridView1, 5);
            no_struk = DateTime.Now.ToString("yy") + "." + DateTime.Now.ToString("MM") + "." + id;
            tanggal = DateTime.Now.ToString();
            kasir = getKolom(dataGridView1, 10);
            masa_aktif = con.GetTglExpired(int.Parse(getKolom(dataGridView1,2))).ToString();
            kelas = getKolom(dataGridView1, 7);
            row = getRow(dataGridView1);
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

    }
}
