using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop_SiFUN_7762.db_sifunTableAdapters;

namespace Desktop_SiFUN_7762.Control
{
    class LoginControl
    {
        TBL_USERTableAdapter TBL_USER = new TBL_USERTableAdapter();

        public bool cekLogin(string user, string password) {
            bool cek = false;
            try {
                if (TBL_USER.GetUser(user, password).ToString() != "") {
                    cek = true;
                }
                else
                {
                    cek = false;
                }
            }
            catch (Exception ex) { ex.ToString(); }
            return cek;
        }

        public int getRoleUser(string user, string password) {
            int role = 0;
            try
            {
                role=int.Parse(TBL_USER.GetIdRole(user,password).ToString());
            }
            catch (Exception ex) {
                role = 0;
                ex.ToString();
            }
            return role;
        }

        public string getNamaPegawai(int id) {
            return TBL_USER.GetNamaPegawai(id);
        }

        public int getIdByUsername(string user) {
            return (int)TBL_USER.GetIdByUsername(user);
        }

        public int getIdPegawaiByIdLogin(int id) {
            return (int)TBL_USER.GetIdPegawaiFromIdLogin(id);
        }
    }
}
