namespace Desktop_SiFUN_7762.Boundary
{
    partial class FormMember
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.lblMember = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.edCari = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jadwalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presensiMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uC_Member1 = new Desktop_SiFUN_7762.Boundary.UC_Member();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(760, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(27, 35);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(21, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Visible = false;
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(0, 35);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(21, 20);
            this.txtRow.TabIndex = 2;
            this.txtRow.Visible = false;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Century Gothic", 27.75F);
            this.lblMember.Location = new System.Drawing.Point(320, 27);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(169, 44);
            this.lblMember.TabIndex = 11;
            this.lblMember.Text = "MEMBER";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(12, 494);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(104, 38);
            this.btnTambah.TabIndex = 12;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(122, 494);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(104, 38);
            this.btnUbah.TabIndex = 13;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // edCari
            // 
            this.edCari.Location = new System.Drawing.Point(6, 15);
            this.edCari.Name = "edCari";
            this.edCari.Size = new System.Drawing.Size(136, 20);
            this.edCari.TabIndex = 15;
            this.edCari.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edCari);
            this.groupBox1.Location = new System.Drawing.Point(624, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 41);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pencarian";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataMasterToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.presensiMemberToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(5, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 18;
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
            // dataMasterToolStripMenuItem
            // 
            this.dataMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pegawaiToolStripMenuItem,
            this.jadwalToolStripMenuItem,
            this.promoToolStripMenuItem,
            this.memberToolStripMenuItem});
            this.dataMasterToolStripMenuItem.Name = "dataMasterToolStripMenuItem";
            this.dataMasterToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.dataMasterToolStripMenuItem.Text = "Data Master";
            // 
            // pegawaiToolStripMenuItem
            // 
            this.pegawaiToolStripMenuItem.Name = "pegawaiToolStripMenuItem";
            this.pegawaiToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.pegawaiToolStripMenuItem.Text = "Pegawai";
            this.pegawaiToolStripMenuItem.Click += new System.EventHandler(this.pegawaiToolStripMenuItem_Click);
            // 
            // jadwalToolStripMenuItem
            // 
            this.jadwalToolStripMenuItem.Name = "jadwalToolStripMenuItem";
            this.jadwalToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.jadwalToolStripMenuItem.Text = "Jadwal";
            this.jadwalToolStripMenuItem.Click += new System.EventHandler(this.jadwalToolStripMenuItem_Click);
            // 
            // promoToolStripMenuItem
            // 
            this.promoToolStripMenuItem.Name = "promoToolStripMenuItem";
            this.promoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.promoToolStripMenuItem.Text = "Promo";
            this.promoToolStripMenuItem.Click += new System.EventHandler(this.promoToolStripMenuItem_Click);
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.memberToolStripMenuItem.Text = "Member";
            this.memberToolStripMenuItem.Click += new System.EventHandler(this.memberToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            this.transaksiToolStripMenuItem.Click += new System.EventHandler(this.transaksiToolStripMenuItem_Click);
            // 
            // presensiMemberToolStripMenuItem
            // 
            this.presensiMemberToolStripMenuItem.Name = "presensiMemberToolStripMenuItem";
            this.presensiMemberToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.presensiMemberToolStripMenuItem.Text = "Presensi Member";
            this.presensiMemberToolStripMenuItem.Click += new System.EventHandler(this.presensiMemberToolStripMenuItem_Click);
            // 
            // uC_Member1
            // 
            this.uC_Member1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Member1.Location = new System.Drawing.Point(197, 78);
            this.uC_Member1.Name = "uC_Member1";
            this.uC_Member1.Size = new System.Drawing.Size(426, 401);
            this.uC_Member1.TabIndex = 17;
            this.uC_Member1.Load += new System.EventHandler(this.uC_Member1_Load);
            // 
            // FormMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.uC_Member1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMember";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMember";
            this.Load += new System.EventHandler(this.FormMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.TextBox edCari;
        private System.Windows.Forms.GroupBox groupBox1;
        private UC_Member uC_Member1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jadwalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presensiMemberToolStripMenuItem;
    }
}