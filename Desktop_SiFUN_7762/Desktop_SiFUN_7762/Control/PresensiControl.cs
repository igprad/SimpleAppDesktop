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
    class PresensiControl
    {
        TBL_PRESENSI_MEMBERTableAdapter presMember = new TBL_PRESENSI_MEMBERTableAdapter();
        TBL_PRESENSI_PEGAWAITableAdapter presPegawai = new TBL_PRESENSI_PEGAWAITableAdapter();
        TBL_MEMBERTableAdapter tbl_member = new TBL_MEMBERTableAdapter();
        TBL_JADWAL_UPDATETableAdapter tbl_jadwal_update = new TBL_JADWAL_UPDATETableAdapter();
        TBL_JADWALTableAdapter tbl_jadwal = new TBL_JADWALTableAdapter();
        TBL_KELASTableAdapter kelas = new TBL_KELASTableAdapter();
        TBL_DEPOSITTableAdapter tbl_deposit = new TBL_DEPOSITTableAdapter();
        TBL_PEGAWAITableAdapter pegawai = new TBL_PEGAWAITableAdapter();
        TBL_KELASTableAdapter TBL_kelas = new TBL_KELASTableAdapter();

        public int CekPresensiInstruktur(int id_jadwal) {
            return (int)presMember.CekPresensiInstruktur(id_jadwal);
        }

        public int GetLastIdPresensi() {
            return (int)presPegawai.GetLastIdPresensi();
        }

        public decimal GetPointPresensiById(int id_pres) {
            return (decimal)presPegawai.GetPointPresensiByIdPresensi(id_pres);
        }

        public void UpdatePointPegawai(decimal selisih, int id_pegawai) {
            pegawai.UpdatePointPresensiPegawai(selisih, id_pegawai);
        }

        public DataTable TampilJadwalByIdMember(int id) {
            return presMember.TampilJadwalByIdMember(id);
        }

        public DataTable TampilJadwalByHariDanIdKelas(int id_kelas, decimal hari) {
            return presMember.GetDataByKelasAndTanggal(id_kelas, hari);
        }
        public DataTable TampilPresensiMember() {
            return presMember.GetData();
        }

        public DataTable TampilPresensiInstruktur() {
            return presPegawai.GetData();
        }

        public DataTable TampilPresensiInstrukturByHariAndKelas(int id,string tanggal) {
            return presPegawai.GetDataByTanggalAndKelas(id, tanggal);
        }

        public DataTable ListJadwalByInstruktur(int id) {
            return tbl_jadwal.GetDataByIdPegawai(id);
        }

        public void EntryPresensiPegawai(PresensiInstrukturEntity input) {
            presPegawai.EntryPresensiPegawai(input.Id_pegawai, input.Id_jadwal, input.Jam_kedatangan, input.Keterangan);
        }

        public DataTable ListMember() {
            return tbl_member.GetMemberByDeposit();
        }

        public DataTable ListInstruktur() {
            return pegawai.GetDataInstuktur();
        }

        public int GetIdMemberByName(string nama) {
            return (int)tbl_member.CariIdMemberDariNama(nama);
        }

        public DataTable GetIdInstruktur() {
            return pegawai.GetDataInstuktur();

        }

        public DateTime getTahunDaftarByIdMember(int id) {
            return (DateTime)tbl_member.GetTglDaftarById(id);
        }

        public string getKeteranganByPresensi(int id)
        {
            return presMember.GetKeteranganPresensiMember(id);
        }

        public string GetNamaKelasByIdPresensiMember(int id) {
            return tbl_jadwal_update.GetNamaKelasByIdPresensi(id);
        }
        public string getNamaKelasById(int id) {
            return kelas.GetNamaKelasById(id).ToString();
        }
        public string GetNamaPegawaiByID(int id) {
            return pegawai.GetNamaByIdPegawai(id);
        }

        public string GetNamaMemberById(int id) {
            return tbl_member.GetNamaByIdMember(id);
        }

        public void EntryPresensiMember(PresensiMemberEntity input) {
            presMember.EntriPresensiMember(input.Id_member, input.Jam_kedatangan, input.Keterangan,input.Id_jadwal);
        }

        public DataTable ListJadwalByMember(int id_member) {
            return presMember.TampilJadwalByIdMember(id_member);
        }

        public DataTable ListKelas() {
            return TBL_kelas.GetData();
        }

        public int GetIdJadwalByPresensiMember(int hari, int id_kelas) {
           return (int)tbl_jadwal_update.GetIdJadwalByKelas_Mulai(id_kelas, (hari).ToString());
           
        }
        public int GetIdKelas(string nama) {
            return (int)kelas.GetIdByNamaKelas(nama);
        }

        public int CekJumlahMember(int id_jadwal_update) {
            return (int)presMember.CheckJumlahMemberPresensi(id_jadwal_update);
        }

        public int CekDepositPertemuanKosong(int id_member, int id_kelas) {
            try
            {
                return (int)tbl_deposit.CekDepositPertemuanKosong(id_member, id_kelas);
            }
            catch (Exception ex) {
                ex.ToString();
                return 0;
            }
        }

        public void UpdateDepositPertemuan(int id_member, int id_kelas) {
            tbl_deposit.UpdateDepositPertemuan(id_kelas, id_member);
        }

        public void KurangiDepositMember(int id_member, decimal harga) {
            presMember.KurangiDepositMember(harga, id_member);
        }

        public double GetHargaKelasByIdMemberDanIdKelas(int id_pres) {
            return (double)tbl_jadwal_update.GetHargaKelasByIdPresensi(id_pres);
        }

        public double GetDepositUangByIdMember(int id_member) {
            return (double)tbl_member.GetDepositUangByIdMember(id_member);
        }

        public int GetDepositByIdMemberDanKelas(int id_kelas, int id_member)
        {
            try
            {
                return (int)tbl_deposit.GetDepositByIdMemberDanKelas(id_kelas, id_member);
            }
            catch (Exception ex) {
                ex.ToString();
                return 0;
            }
        }
    }
}
