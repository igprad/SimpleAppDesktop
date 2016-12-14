using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Desktop_SiFUN_7762.db_sifunTableAdapters;
using Desktop_SiFUN_7762.Entity;

namespace Desktop_SiFUN_7762.Control
{
    class TransaksiControl
    {
        TBL_TRANSAKSITableAdapter tbl_transaksi = new TBL_TRANSAKSITableAdapter();
        TBL_PROMOTableAdapter tbl_promo = new TBL_PROMOTableAdapter();
        TBL_MEMBERTableAdapter tbl_member = new TBL_MEMBERTableAdapter();
        TBL_KELASTableAdapter tbl_kelas = new TBL_KELASTableAdapter();
        TBL_DEPOSITTableAdapter tbl_deposit = new TBL_DEPOSITTableAdapter();
            
        public DataTable GetDataPromo() {
            return tbl_promo.GetData();
        }

        public DataTable GetDataTransaksiByDate(String input) {
            return tbl_transaksi.GetTransaksiByDate(input);
        }

        public DataTable GetDataMember() {
            return tbl_member.GetDataByNonAktif();
        }

        public DataTable GetMember() {
            return tbl_member.GetData();
        }

        public DataTable GetDataMemberAktif() {
            return tbl_member.GetMemberAktif();
        }

        public DataTable GetDataTransaksi()
        {
            return tbl_transaksi.GetData();
        }

        public DataTable GetDataKelas() {
            return tbl_kelas.GetData();
        }

        public String GetNamaMemberById(int id) {
            return tbl_member.GetNamaByIdMember(id);
        }

        public String GetNamaKelasById(int id) {
            return (string)tbl_kelas.GetNamaKelasById(id);
        }

        public void AktivasiTahunanMemberGetMember(int id_pengajak, int id_diajak) {
            tbl_member.AktivasiTahunan(id_diajak);
            tbl_member.UpdateBonusPengajakGetMember(id_pengajak);
        }

        public void AktivasiCouple(int id_1, int id_2) {
            tbl_member.AktivasiTahunan(id_1);
            tbl_member.AktivasiTahunan(id_2);
        }

        public void AktivasiReguler(int id) {
            tbl_member.AktivasiTahunan(id);
        }

        public void TambahTransaksi(int id_pro, int id_mem, int? id_kel, DateTime tgl, decimal biaya,int pegawai) {
            tbl_transaksi.TambahTransaksi(id_pro, id_mem, id_kel, tgl, biaya,pegawai);
        }

        public void DepositReguler(int id_member, decimal jumlah_deposit) {
            tbl_member.UpdateDepositUang(jumlah_deposit, id_member);
        }

        public decimal GetHargaPromo(int id_promo) {
            return (decimal)tbl_promo.GetHargaPromo(id_promo);
        }

        public decimal GetDepositByIDMember(int id_member) {
            return (decimal)tbl_member.GetDepositUangByIdMember(id_member);
        }

        public decimal GetHargaKelasSenam(int id_kelas) {
            return (decimal)tbl_kelas.GetHargaKelasById(id_kelas);
        }

        public bool IsActiveMember(int id_member){
            bool temp = false;
            if (tbl_member.GetStatusMember(id_member) == "Aktif")
                temp = true;
            return temp;
        }

        public bool IsDepositMemberExist(int id_member,int id_kelas) {
            bool temp = false;
            if ((int)tbl_deposit.GetCountIdDeposit(id_kelas, id_member) > 0)
                temp = true;
            return temp;
        }

        public void TambahDepositKelas(int id_member, int id_kelas,int deposit,string keterangan) {
            tbl_deposit.TambahDeposit(id_kelas, id_member, deposit, keterangan);
        }

        public void UpdateDepositKelas(int id_member, int id_kelas,int deposit) {
            tbl_deposit.UpdatePertemuanJikaAda(deposit,GetIdDeposit(id_member,id_kelas));
        }


        public int GetIdDeposit(int id_member,int id_kelas)
        {
            return (int)tbl_deposit.GetIdDepositByIdMemberAndIdKelas(id_kelas, id_member);
        }

        public DateTime GetTglExpired(int id_member) {
            return (DateTime)tbl_member.GetTglHabisAktif(id_member);
        }

        public string GetNamaPromoByTransaksi(int id_promo) {
            return tbl_transaksi.GetPromoByIdTransaksi(id_promo);
        }

        public int GetLastIdTransaksi()
        {
            return (int)tbl_transaksi.GetLastIdTransaksi();
        }
    }
}
