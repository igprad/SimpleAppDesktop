using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.VisualBasic;

namespace Desktop_SiFUN_7762.Boundary
{
    public partial class CetakStrukTransaksi : Form
    {
        private string id_member, nama, harga, no_struk, tanggal,kasir,masa_aktif,kelas,promo;
        private string id_member_pengajak, nama_member_pengajak;
        
        public CetakStrukTransaksi()
        {
            InitializeComponent();
        }

        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {



            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New",10); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            
            
            int offset = 40;

            graphic.DrawString(listBox1.Items[0].ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            graphic.DrawString(listBox1.Items[1].ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            graphic.DrawString(listBox1.Items[2].ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            graphic.DrawString(listBox1.Items[3].ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            graphic.DrawString(listBox1.Items[4].ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            graphic.DrawString(listBox1.Items[5].ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            graphic.DrawString(listBox1.Items[6].ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
            graphic.DrawString(listBox1.Items[7].ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);

        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument; //add the document to the dialog box...        

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();
                btnBatal_Click(sender, e);
            }
        }

        private void CetakStrukTransaksi_Load(object sender, EventArgs e)
        {
            
        }

        public void InputCetakStruk(string id,string nama,string harga,string no_cetak,string tgl,string namakas,string aktif,string namkelas,string prom,string no_member_pengajak,string nama_pengajak) {
            id_member=id; 
            this.nama=nama; 
            this.harga=harga; 
            no_struk=no_cetak; 
            tanggal=tgl; 
            kasir=namakas; 
            masa_aktif=aktif; 
            kelas=namkelas;
            promo = prom;
            nama_member_pengajak = nama_pengajak;
            id_member_pengajak = no_member_pengajak;
        }

        public void setListBox(string kelasParam){
            listBox1.Items.Add("Fit & Fun".PadRight(50)+" No Struk:"+no_struk);
            listBox1.Items.Add("Jl. Centralpark No.10 Yogyakarta".PadRight(35)+" Tanggal:"+tanggal);
            listBox1.Items.Add("\n");
            listBox1.Items.Add("Member".PadRight(26)+":"+id_member+"/"+nama);
            if (kelasParam==""&&promo!="Deposit")
            {
                listBox1.Items.Add("Aktivasi(" + promo + ")".PadRight(10) + ":" + harga);
                listBox1.Items.Add("Masa aktif member  ".PadRight(17) + ":" + masa_aktif);
            }
            else {
                listBox1.Items.Add("Deposit(" + promo + ")".PadRight(10) + ":" + harga);
                if(promo!="Deposit")
                    listBox1.Items.Add("Jenis Senam ".PadRight(17) + ":" + kelas);
            }
            listBox1.Items.Add("\n");
            listBox1.Items.Add("\t".PadRight(40)+"Kasir :"+kasir);
        }

        public void setListBoxSetelahTransaksi(string kelasParam)
        {
            listBox1.Items.Add("Fit & Fun".PadRight(50) + " No Struk:" + no_struk);
            listBox1.Items.Add("Jl. Centralpark No.10 Yogyakarta".PadRight(35) + " Tanggal:" + tanggal);
            listBox1.Items.Add("\n");
            if (promo == "Aktivasi_GetMember")
            {
                listBox1.Items.Add("Member".PadRight(26) + ":" + id_member + "/" + nama+" ref By :"+id_member_pengajak+"/"+nama_member_pengajak); 
            }
            else { 
                listBox1.Items.Add("Member".PadRight(26) + ":" + id_member + "/" + nama); 
            } 
            if (kelasParam == "" && promo != "Deposit")
            {
                listBox1.Items.Add("Aktivasi(" + promo + ")".PadRight(10) + ":" + harga);
                listBox1.Items.Add("Masa aktif member  ".PadRight(17) + ":" + masa_aktif);
            }
            else
            {
                listBox1.Items.Add("Deposit(" + promo + ")".PadRight(10) + ":" + harga);
                if (promo != "Deposit")
                    listBox1.Items.Add("Jenis Senam ".PadRight(17) + ":" + kelas);
            }
            listBox1.Items.Add("\n");
            listBox1.Items.Add("\t".PadRight(40) + "Kasir :" + kasir);
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
