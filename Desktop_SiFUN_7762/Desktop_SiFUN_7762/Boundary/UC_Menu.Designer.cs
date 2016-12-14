namespace Desktop_SiFUN_7762.Boundary
{
    partial class UC_Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.edNama = new System.Windows.Forms.TextBox();
            this.edAlamat = new System.Windows.Forms.TextBox();
            this.edEmail = new System.Windows.Forms.TextBox();
            this.edNomor = new System.Windows.Forms.TextBox();
            this.cmbJabatan = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nomor HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jabatan/Role";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(82, 304);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(89, 39);
            this.btnTambah.TabIndex = 5;
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(224, 304);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(88, 39);
            this.btnBatal.TabIndex = 6;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.button2_Click);
            // 
            // edNama
            // 
            this.edNama.Location = new System.Drawing.Point(108, 49);
            this.edNama.MaxLength = 25;
            this.edNama.Name = "edNama";
            this.edNama.Size = new System.Drawing.Size(265, 20);
            this.edNama.TabIndex = 7;
            // 
            // edAlamat
            // 
            this.edAlamat.Location = new System.Drawing.Point(108, 86);
            this.edAlamat.MaxLength = 50;
            this.edAlamat.Name = "edAlamat";
            this.edAlamat.Size = new System.Drawing.Size(265, 20);
            this.edAlamat.TabIndex = 8;
            // 
            // edEmail
            // 
            this.edEmail.Location = new System.Drawing.Point(108, 126);
            this.edEmail.MaxLength = 40;
            this.edEmail.Name = "edEmail";
            this.edEmail.Size = new System.Drawing.Size(265, 20);
            this.edEmail.TabIndex = 9;
            this.edEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edEmail_KeyPress);
            // 
            // edNomor
            // 
            this.edNomor.Location = new System.Drawing.Point(108, 173);
            this.edNomor.MaxLength = 15;
            this.edNomor.Name = "edNomor";
            this.edNomor.Size = new System.Drawing.Size(265, 20);
            this.edNomor.TabIndex = 10;
            this.edNomor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edNomor_KeyPress);
            // 
            // cmbJabatan
            // 
            this.cmbJabatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJabatan.FormattingEnabled = true;
            this.cmbJabatan.Location = new System.Drawing.Point(109, 214);
            this.cmbJabatan.Name = "cmbJabatan";
            this.cmbJabatan.Size = new System.Drawing.Size(148, 21);
            this.cmbJabatan.TabIndex = 11;
            this.cmbJabatan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(398, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(25, 20);
            this.txtID.TabIndex = 12;
            this.txtID.Visible = false;
            // 
            // UC_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cmbJabatan);
            this.Controls.Add(this.edNomor);
            this.Controls.Add(this.edEmail);
            this.Controls.Add(this.edAlamat);
            this.Controls.Add(this.edNama);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_Menu";
            this.Size = new System.Drawing.Size(426, 401);
            this.Load += new System.EventHandler(this.UC_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.TextBox edNama;
        private System.Windows.Forms.TextBox edAlamat;
        private System.Windows.Forms.TextBox edEmail;
        private System.Windows.Forms.TextBox edNomor;
        private System.Windows.Forms.ComboBox cmbJabatan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Button btnTambah;
    }
}
