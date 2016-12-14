namespace Desktop_SiFUN_7762.Boundary
{
    partial class UC_Promo
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
            this.lblPromo = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.edKeterangan = new System.Windows.Forms.TextBox();
            this.edHarga = new System.Windows.Forms.TextBox();
            this.edPromo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPromo
            // 
            this.lblPromo.AutoSize = true;
            this.lblPromo.Location = new System.Drawing.Point(44, 54);
            this.lblPromo.Name = "lblPromo";
            this.lblPromo.Size = new System.Drawing.Size(68, 13);
            this.lblPromo.TabIndex = 0;
            this.lblPromo.Text = "Nama Promo";
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(44, 137);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(36, 13);
            this.lblHarga.TabIndex = 1;
            this.lblHarga.Text = "Harga";
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Location = new System.Drawing.Point(44, 201);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(62, 13);
            this.lblKeterangan.TabIndex = 2;
            this.lblKeterangan.Text = "Keterangan";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(84, 299);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(86, 41);
            this.btnTambah.TabIndex = 3;
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(227, 299);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(86, 41);
            this.btnBatal.TabIndex = 4;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // edKeterangan
            // 
            this.edKeterangan.Location = new System.Drawing.Point(118, 176);
            this.edKeterangan.Multiline = true;
            this.edKeterangan.Name = "edKeterangan";
            this.edKeterangan.Size = new System.Drawing.Size(260, 93);
            this.edKeterangan.TabIndex = 5;
            // 
            // edHarga
            // 
            this.edHarga.Location = new System.Drawing.Point(118, 134);
            this.edHarga.Name = "edHarga";
            this.edHarga.Size = new System.Drawing.Size(147, 20);
            this.edHarga.TabIndex = 6;
            // 
            // edPromo
            // 
            this.edPromo.Location = new System.Drawing.Point(118, 54);
            this.edPromo.Name = "edPromo";
            this.edPromo.Size = new System.Drawing.Size(190, 20);
            this.edPromo.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(401, 0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(25, 20);
            this.txtID.TabIndex = 8;
            this.txtID.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Jenis Promo";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aktivasi",
            "Deposit",
            "Bayar"});
            this.comboBox1.Location = new System.Drawing.Point(118, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // UC_Promo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.edPromo);
            this.Controls.Add(this.edHarga);
            this.Controls.Add(this.edKeterangan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.lblKeterangan);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblPromo);
            this.Name = "UC_Promo";
            this.Size = new System.Drawing.Size(426, 401);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPromo;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.TextBox edKeterangan;
        private System.Windows.Forms.TextBox edHarga;
        private System.Windows.Forms.TextBox edPromo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}
