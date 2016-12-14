using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop_SiFUN_7762.db_sifunTableAdapters;
using System.Data;
using Desktop_SiFUN_7762.Entity;

namespace Desktop_SiFUN_7762.Control
{
    class PegawaiControl
    {
        TBL_PEGAWAITableAdapter tbl_pegawai = new TBL_PEGAWAITableAdapter();
        TBL_ROLETableAdapter tbl_role = new TBL_ROLETableAdapter();
        TBL_USERTableAdapter tbl_user = new TBL_USERTableAdapter();

        public DataTable TampilPegawai() {
            return tbl_pegawai.GetData();
        }

        public DataTable getRole() {
            return tbl_role.GetData();
        }

        public int getIDRole(string input) {
            return tbl_role.GetIdRole(input).Value;
        }

        public string getNamaRoleById(int id) {
            return tbl_role.GetNamaRoleByID(id);
        }

        public int getLastIdPegawai()
        {
            return (int)tbl_pegawai.GetLastIdPegawai();
        }

        public int getLastIdLogin() {
            return (int)tbl_user.GetLastIdLogin();
        }

        public void EntryUserPegawai(int role,string username,string pass) {
            tbl_user.EntryUser(role,username, pass);
        }

        public void EntryPegawai(PegawaiEntity input) {
            tbl_pegawai.EntryPegawai(input.Id_role, input.Nama_pegawai, input.Alamat, input.Email, input.Nohp,input.Id_login);
            
        }

        public void EditPegawai(PegawaiEntity baru,int id_pegawai) {
            tbl_pegawai.UpdatePegawai(baru.Id_role, baru.Nama_pegawai, baru.Alamat, baru.Email, baru.Nohp, id_pegawai);
        }

        public void HapusPegawai(int id_pegawai) {
            tbl_pegawai.HapusPegawai(id_pegawai);
        }

        public int CekDataDuplikasi(PegawaiEntity input) {
            return (int)tbl_pegawai.CekDataDuplikasi(input.Nama_pegawai, input.Email, input.Nohp);
        }

    }
}
