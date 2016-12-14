namespace Desktop_SiFUN_7762.Boundary
{
    partial class UC_Member
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.edNama = new System.Windows.Forms.TextBox();
            this.edAlamat = new System.Windows.Forms.TextBox();
            this.edEmail = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(405, 0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(21, 20);
            this.txtID.TabIndex = 0;
            this.txtID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tanggal Lahir";
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(78, 324);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(88, 37);
            this.btnTambah.TabIndex = 5;
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(262, 324);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(88, 37);
            this.btnBatal.TabIndex = 6;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // edNama
            // 
            this.edNama.Location = new System.Drawing.Point(120, 62);
            this.edNama.Name = "edNama";
            this.edNama.Size = new System.Drawing.Size(230, 20);
            this.edNama.TabIndex = 7;
            // 
            // edAlamat
            // 
            this.edAlamat.Location = new System.Drawing.Point(120, 105);
            this.edAlamat.Multiline = true;
            this.edAlamat.Name = "edAlamat";
            this.edAlamat.Size = new System.Drawing.Size(230, 65);
            this.edAlamat.TabIndex = 8;
            // 
            // edEmail
            // 
            this.edEmail.Location = new System.Drawing.Point(120, 193);
            this.edEmail.Name = "edEmail";
            this.edEmail.Size = new System.Drawing.Size(230, 20);
            this.edEmail.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 239);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.edEmail);
            this.Controls.Add(this.edAlamat);
            this.Controls.Add(this.edNama);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Name = "UC_Member";
            this.Size = new System.Drawing.Size(422, 397);
            this.Load += new System.EventHandler(this.UC_Member_Load);
            this.VisibleChanged += new System.EventHandler(this.UC_Member_VisibleChanged);
            this.Click += new System.EventHandler(this.UC_Member_Click);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.TextBox edAlamat;
        private System.Windows.Forms.TextBox edEmail;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox edNama;
        public System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
