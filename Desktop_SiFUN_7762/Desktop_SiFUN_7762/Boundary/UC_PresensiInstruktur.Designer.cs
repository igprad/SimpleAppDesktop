namespace Desktop_SiFUN_7762.Boundary
{
    partial class UC_PresensiInstruktur
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblJadwal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbIDPegawai = new System.Windows.Forms.ComboBox();
            this.cmbJadwal = new System.Windows.Forms.ComboBox();
            this.txtKeterangan = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJadwal
            // 
            this.lblJadwal.AutoSize = true;
            this.lblJadwal.Location = new System.Drawing.Point(20, 106);
            this.lblJadwal.Name = "lblJadwal";
            this.lblJadwal.Size = new System.Drawing.Size(40, 13);
            this.lblJadwal.TabIndex = 11;
            this.lblJadwal.Text = "Jadwal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Keterangan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pegawai";
            // 
            // cmbIDPegawai
            // 
            this.cmbIDPegawai.FormattingEnabled = true;
            this.cmbIDPegawai.Location = new System.Drawing.Point(83, 45);
            this.cmbIDPegawai.Name = "cmbIDPegawai";
            this.cmbIDPegawai.Size = new System.Drawing.Size(180, 21);
            this.cmbIDPegawai.TabIndex = 12;
            // 
            // cmbJadwal
            // 
            this.cmbJadwal.FormattingEnabled = true;
            this.cmbJadwal.Location = new System.Drawing.Point(83, 106);
            this.cmbJadwal.Name = "cmbJadwal";
            this.cmbJadwal.Size = new System.Drawing.Size(180, 21);
            this.cmbJadwal.TabIndex = 13;
            // 
            // txtKeterangan
            // 
            this.txtKeterangan.Location = new System.Drawing.Point(83, 166);
            this.txtKeterangan.Multiline = true;
            this.txtKeterangan.Name = "txtKeterangan";
            this.txtKeterangan.Size = new System.Drawing.Size(299, 128);
            this.txtKeterangan.TabIndex = 14;
            this.txtKeterangan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(20, 349);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(96, 41);
            this.btnTambah.TabIndex = 15;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(122, 349);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(98, 41);
            this.btnBatal.TabIndex = 16;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(466, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 317);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKeterangan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblJadwal);
            this.groupBox1.Controls.Add(this.cmbIDPegawai);
            this.groupBox1.Controls.Add(this.cmbJadwal);
            this.groupBox1.Location = new System.Drawing.Point(20, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 317);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Presensi";
            // 
            // UC_PresensiInstruktur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnTambah);
            this.Name = "UC_PresensiInstruktur";
            this.Size = new System.Drawing.Size(996, 466);
            this.Load += new System.EventHandler(this.UC_PresensiInstruktur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblJadwal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIDPegawai;
        private System.Windows.Forms.ComboBox cmbJadwal;
        private System.Windows.Forms.TextBox txtKeterangan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
