using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Desktop_SiFUN_7762.Entity;
using Desktop_SiFUN_7762.db_sifunTableAdapters;

namespace Desktop_SiFUN_7762.Control
{
    class JadwalControl
    {
        TBL_JADWALTableAdapter jadwalNormal = new TBL_JADWALTableAdapter();
        TBL_JADWAL_UPDATETableAdapter jadwalUpdate = new TBL_JADWAL_UPDATETableAdapter();
        TBL_PEGAWAITableAdapter tbl_pegawai = new TBL_PEGAWAITableAdapter();
        TBL_KELASTableAdapter tbl_kelas = new TBL_KELASTableAdapter();

        public int LastIdBeforeUpdate() {
            return (int)jadwalUpdate.LastId();
        }

        public void GenerateOneWeekJadwal() {
            jadwalUpdate.GenerateOneWeekJadwal();
        }

        public DataTable TampilJadwalByHari(int hari) {
            return jadwalNormal.GetDataJadwalByHari(hari.ToString());
        }

        public DataTable TampilJadwalUpToDate() {
            return jadwalUpdate.GetData();
        }

        public DataTable TampilJadwal() {
            return jadwalNormal.GetData();
        }

        public DataTable ListPegawai() {
            return tbl_pegawai.GetData();
        }

        public DataTable ListKelas() {
            return tbl_kelas.GetData();
        }

        public int GetIdPegawaiByNama(string nama) {
            return (int)jadwalNormal.GetIdPegawaiByName(nama);
        }

        public int GetIdKelasByNama(string nama)
        {
            return (int)jadwalNormal.GetIdKelasByNama(nama);
        }
        public string GetNamaPegawaiById(int id) {
            return (string)jadwalNormal.GetNamaPegawaiById(id);
        }

        public void EntryJadwal(JadwalEntity input) {
           jadwalNormal.EntryJadwal(input.Id_kelas, input.Id_pegawai, input.Hari, input.Jam_mulai, input.Jam_selesai);
           //jadwalUpdate.EntryJadwalUpdate(input.Id_kelas, input.Id_pegawai, input.Hari, input.Jam_mulai, input.Jam_selesai);
        }

        public void UbahJadwal(JadwalEntity input,int id) {
            jadwalNormal.UbahJadwal(input.Id_kelas, input.Id_pegawai, input.Hari, input.Jam_mulai, input.Jam_selesai,id);
            //jadwalUpdate.UbahJadwalUpdate(input.Id_kelas, input.Id_pegawai, input.Hari, input.Jam_mulai, input.Jam_selesai, id);
        }

        public void HapusJadwal(int id) {
            jadwalNormal.HapusJadwal(id);
            //jadwalUpdate.HapusJadwalUpdate(id);
        }

        public int cekUnikJadwal(JadwalEntity input) {
            return (int)jadwalNormal.CekJadwalUnik(input.Hari, input.Jam_mulai, input.Jam_selesai, input.Id_kelas, input.Id_pegawai);
        }

        public int cekJamJadwal(string hari, string mulai, string selesai) {
            return (int)jadwalNormal.CekAdaJadwalTabrakan(hari, mulai, selesai);
        }
    }
}
