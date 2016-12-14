namespace Desktop_SiFUN_7762.Boundary
{
    partial class Transaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblNama2 = new System.Windows.Forms.Label();
            this.lblIdMember2 = new System.Windows.Forms.Label();
            this.cmbIdMember2 = new System.Windows.Forms.ComboBox();
            this.txtNamaMember2 = new System.Windows.Forms.TextBox();
            this.lblIdKelas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamaMember = new System.Windows.Forms.TextBox();
            this.cmbKelas = new System.Windows.Forms.ComboBox();
            this.cmbMember = new System.Windows.Forms.ComboBox();
            this.cmbPromo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalHarga = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presensiMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCetak = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gb_deposit = new System.Windows.Forms.GroupBox();
            this.txtDepositPertemuan = new System.Windows.Forms.TextBox();
            this.lblTotalDeposit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_deposit.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDeposit);
            this.groupBox1.Controls.Add(this.lblDeposit);
            this.groupBox1.Controls.Add(this.lblNama2);
            this.groupBox1.Controls.Add(this.lblIdMember2);
            this.groupBox1.Controls.Add(this.cmbIdMember2);
            this.groupBox1.Controls.Add(this.txtNamaMember2);
            this.groupBox1.Controls.Add(this.lblIdKelas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNamaMember);
            this.groupBox1.Controls.Add(this.cmbKelas);
            this.groupBox1.Controls.Add(this.cmbMember);
            this.groupBox1.Controls.Add(this.cmbPromo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(5, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 569);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pengelolaan";
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(126, 513);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(267, 23);
            this.txtDeposit.TabIndex = 15;
            this.txtDeposit.Visible = false;
            this.txtDeposit.TextChanged += new System.EventHandler(this.txtDeposit_TextChanged);
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(8, 513);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(56, 17);
            this.lblDeposit.TabIndex = 9;
            this.lblDeposit.Text = "Deposit";
            this.lblDeposit.Visible = false;
            // 
            // lblNama2
            // 
            this.lblNama2.AutoSize = true;
            this.lblNama2.Location = new System.Drawing.Point(8, 419);
            this.lblNama2.Name = "lblNama2";
            this.lblNama2.Size = new System.Drawing.Size(156, 17);
            this.lblNama2.TabIndex = 14;
            this.lblNama2.Text = "Nama Couple/Pengajak";
            this.lblNama2.Visible = false;
            // 
            // lblIdMember2
            // 
            this.lblIdMember2.AutoSize = true;
            this.lblIdMember2.Location = new System.Drawing.Point(8, 329);
            this.lblIdMember2.Name = "lblIdMember2";
            this.lblIdMember2.Size = new System.Drawing.Size(187, 17);
            this.lblIdMember2.TabIndex = 13;
            this.lblIdMember2.Text = "ID Member Couple/Pengajak";
            this.lblIdMember2.Visible = false;
            // 
            // cmbIdMember2
            // 
            this.cmbIdMember2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbIdMember2.FormattingEnabled = true;
            this.cmbIdMember2.Location = new System.Drawing.Point(126, 349);
            this.cmbIdMember2.Name = "cmbIdMember2";
            this.cmbIdMember2.Size = new System.Drawing.Size(267, 24);
            this.cmbIdMember2.TabIndex = 12;
            this.cmbIdMember2.Visible = false;
            this.cmbIdMember2.SelectedIndexChanged += new System.EventHandler(this.cmbIdMember2_SelectedIndexChanged);
            // 
            // txtNamaMember2
            // 
            this.txtNamaMember2.Location = new System.Drawing.Point(126, 439);
            this.txtNamaMember2.Name = "txtNamaMember2";
            this.txtNamaMember2.ReadOnly = true;
            this.txtNamaMember2.Size = new System.Drawing.Size(267, 23);
            this.txtNamaMember2.TabIndex = 11;
            this.txtNamaMember2.Visible = false;
            // 
            // lblIdKelas
            // 
            this.lblIdKelas.AutoSize = true;
            this.lblIdKelas.Location = new System.Drawing.Point(8, 244);
            this.lblIdKelas.Name = "lblIdKelas";
            this.lblIdKelas.Size = new System.Drawing.Size(43, 17);
            this.lblIdKelas.TabIndex = 9;
            this.lblIdKelas.Text = "Kelas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nama Member";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID Member";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Promo";
            // 
            // txtNamaMember
            // 
            this.txtNamaMember.Location = new System.Drawing.Point(126, 179);
            this.txtNamaMember.Name = "txtNamaMember";
            this.txtNamaMember.ReadOnly = true;
            this.txtNamaMember.Size = new System.Drawing.Size(267, 23);
            this.txtNamaMember.TabIndex = 3;
            // 
            // cmbKelas
            // 
            this.cmbKelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKelas.FormattingEnabled = true;
            this.cmbKelas.Location = new System.Drawing.Point(126, 244);
            this.cmbKelas.Name = "cmbKelas";
            this.cmbKelas.Size = new System.Drawing.Size(267, 24);
            this.cmbKelas.TabIndex = 2;
            this.cmbKelas.SelectedIndexChanged += new System.EventHandler(this.cmbKelas_SelectedIndexChanged);
            // 
            // cmbMember
            // 
            this.cmbMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMember.FormattingEnabled = true;
            this.cmbMember.Location = new System.Drawing.Point(126, 115);
            this.cmbMember.Name = "cmbMember";
            this.cmbMember.Size = new System.Drawing.Size(267, 24);
            this.cmbMember.TabIndex = 1;
            this.cmbMember.SelectedIndexChanged += new System.EventHandler(this.cmbMember_SelectedIndexChanged);
            // 
            // cmbPromo
            // 
            this.cmbPromo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPromo.FormattingEnabled = true;
            this.cmbPromo.Location = new System.Drawing.Point(126, 34);
            this.cmbPromo.Name = "cmbPromo";
            this.cmbPromo.Size = new System.Drawing.Size(267, 24);
            this.cmbPromo.TabIndex = 0;
            this.cmbPromo.SelectedIndexChanged += new System.EventHandler(this.cmbPromo_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalHarga);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(480, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Pembayaran";
            // 
            // txtTotalHarga
            // 
            this.txtTotalHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtTotalHarga.Location = new System.Drawing.Point(156, 29);
            this.txtTotalHarga.Multiline = true;
            this.txtTotalHarga.Name = "txtTotalHarga";
            this.txtTotalHarga.ReadOnly = true;
            this.txtTotalHarga.Size = new System.Drawing.Size(719, 46);
            this.txtTotalHarga.TabIndex = 1;
            this.txtTotalHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTotal.Location = new System.Drawing.Point(21, 29);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 46);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Rp";
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Location = new System.Drawing.Point(5, 707);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(134, 53);
            this.btnTransaksi.TabIndex = 5;
            this.btnTransaksi.Text = "Bayar";
            this.btnTransaksi.UseVisualStyleBackColor = true;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.presensiMemberToolStripMenuItem,
            this.registerMemberToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(5, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1356, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // presensiMemberToolStripMenuItem
            // 
            this.presensiMemberToolStripMenuItem.Name = "presensiMemberToolStripMenuItem";
            this.presensiMemberToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.presensiMemberToolStripMenuItem.Text = "Presensi Member";
            this.presensiMemberToolStripMenuItem.Click += new System.EventHandler(this.presensiMemberToolStripMenuItem_Click);
            // 
            // registerMemberToolStripMenuItem
            // 
            this.registerMemberToolStripMenuItem.Name = "registerMemberToolStripMenuItem";
            this.registerMemberToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.registerMemberToolStripMenuItem.Text = "Register Member";
            this.registerMemberToolStripMenuItem.Click += new System.EventHandler(this.registerMemberToolStripMenuItem_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(145, 707);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(134, 53);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(480, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(881, 543);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaksi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(869, 518);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(480, 707);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(108, 53);
            this.btnCetak.TabIndex = 9;
            this.btnCetak.Text = "CETAK";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(480, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // gb_deposit
            // 
            this.gb_deposit.Controls.Add(this.txtDepositPertemuan);
            this.gb_deposit.Controls.Add(this.lblTotalDeposit);
            this.gb_deposit.Location = new System.Drawing.Point(5, 32);
            this.gb_deposit.Name = "gb_deposit";
            this.gb_deposit.Size = new System.Drawing.Size(469, 84);
            this.gb_deposit.TabIndex = 11;
            this.gb_deposit.TabStop = false;
            this.gb_deposit.Text = "Total Deposit Kelas";
            // 
            // txtDepositPertemuan
            // 
            this.txtDepositPertemuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtDepositPertemuan.Location = new System.Drawing.Point(140, 29);
            this.txtDepositPertemuan.Multiline = true;
            this.txtDepositPertemuan.Name = "txtDepositPertemuan";
            this.txtDepositPertemuan.ReadOnly = true;
            this.txtDepositPertemuan.Size = new System.Drawing.Size(323, 46);
            this.txtDepositPertemuan.TabIndex = 3;
            this.txtDepositPertemuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalDeposit
            // 
            this.lblTotalDeposit.AutoSize = true;
            this.lblTotalDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTotalDeposit.Location = new System.Drawing.Point(15, 23);
            this.lblTotalDeposit.Name = "lblTotalDeposit";
            this.lblTotalDeposit.Size = new System.Drawing.Size(119, 52);
            this.lblTotalDeposit.TabIndex = 2;
            this.lblTotalDeposit.Text = "Deposit \r\nPertemuan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1320, 727);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_deposit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTransaksi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Transaksi";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Transaksi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_deposit.ResumeLayout(false);
            this.gb_deposit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presensiMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTotalHarga;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtNamaMember;
        private System.Windows.Forms.ComboBox cmbKelas;
        private System.Windows.Forms.ComboBox cmbMember;
        private System.Windows.Forms.ComboBox cmbPromo;
        private System.Windows.Forms.Label lblIdKelas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNama2;
        private System.Windows.Forms.Label lblIdMember2;
        private System.Windows.Forms.ComboBox cmbIdMember2;
        private System.Windows.Forms.TextBox txtNamaMember2;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.ToolStripMenuItem registerMemberToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gb_deposit;
        private System.Windows.Forms.Label lblTotalDeposit;
        private System.Windows.Forms.TextBox txtDepositPertemuan;
        private System.Windows.Forms.Label label1;

    }
}