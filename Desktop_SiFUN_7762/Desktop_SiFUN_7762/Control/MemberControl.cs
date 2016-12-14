using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop_SiFUN_7762.Entity;
using Desktop_SiFUN_7762.db_sifunTableAdapters;
using System.Data;

namespace Desktop_SiFUN_7762.Control
{
    class MemberControl
    {
        TBL_MEMBERTableAdapter tbl_member = new TBL_MEMBERTableAdapter();
        TBL_USERTableAdapter tbl_user = new TBL_USERTableAdapter();
        
//==============================================================TAMBAHAN UNTUK RECORD MEMBER==========================================================================
        public int cekAdaTidakRecordMember(string bulan, string tahun) {
            return (int)tbl_member.CekAdaRecordMember(bulan, tahun);
        }

        public void InsertRecordMemberBaru(string bulan, string tahun, int aktif, int non_aktif, int total) {
            tbl_member.TambahRecordMember(bulan, tahun, aktif, non_aktif, total);
        }

        public void TambahAktifMember(string bulan, string tahun) {
            tbl_member.TambahMemberAktifBulanTahun(bulan, tahun);
        }

        public void TambahNonAktifMember(string bulan, string tahun) {
            tbl_member.TambahMemberNonAktifBulanTahun(bulan, tahun);
        }

        public void UbahAktifMember(string bulan, string tahun) {
            tbl_member.UbahMemberAktifBulanTahun(bulan, tahun);
        }

        public void ubahNonAktifMember(string bulan, string tahun) {
            tbl_member.UbahMemberNonAktifBulanTahun(bulan, tahun);
        }

        public int totalMemberAktif() {
            return (int)tbl_member.JumlahMemberAktif();
        }
        public int totalMemberNonAktif()
        {
            return (int)tbl_member.JumlahMemberNonAktif();
        }
//==============================================================TAMBAHAN UNTUK RECORD MEMBER==========================================================================
        public DataTable TampilMember() {
            return tbl_member.GetData();
        }

        public DataTable TampilMemberBy(string key) {
            return tbl_member.GetDataByMember(key);
        }

        public void EntryUsername(string username, string password) {
            tbl_user.EntryUser(5, username, password);
        }

        public int GetIdByUsername(string username) {
            return (int)tbl_user.GetIdByUsername(username);
        }

        public int GetLastIdMember() {
            return (int)tbl_member.GetLastIdMember();
        }

        public void EntryMember(string nama, string email, string alamat,string tanggal_lahir,string dua_digit_tahun) { // ini masih error --updated sudah
            
            tbl_member.EntryMember(nama, alamat, email, 0, "Non-Aktif", DateTime.Now, null, DateTime.Now);
            EntryUsername(tbl_member.GetNoMember((int)tbl_member.GetLastIdMember()), tanggal_lahir.ToString()+"/"+dua_digit_tahun);
            tbl_member.UpdateIdLogin((int)tbl_user.GetLastIdLogin(),(int)tbl_member.GetLastIdMember());
        }

        public void EditMember(string nama, string alamat, string email, int id) {
            tbl_member.EditMember(nama, alamat, email, id);
        }

        public void HapusMember(int id) {
            tbl_member.HapusMember(id);
        }

        public int DeaktivasiMember() {
            return (int)tbl_member.DeaktivasiMember();
        }

        public int CekMemberUnik(string nama,string alamat,string email) {
            return (int)tbl_member.CekMemberUnik(nama,(GetLastIdMember() + 1).ToString(), alamat, email);
        }
    }
}
