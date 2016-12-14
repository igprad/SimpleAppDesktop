using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_SiFUN_7762.Entity
{
    class PegawaiEntity
    {
        private int id_role, id_login;

        public int Id_login
        {
            get { return id_login; }
            set { id_login = value; }
        }

        public int Id_role
        {
            get { return id_role; }
            set { id_role = value; }
        }
        private string nama_pegawai, alamat, email, nohp;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Alamat
        {
            get { return alamat; }
            set { alamat = value; }
        }

        public string Nama_pegawai
        {
            get { return nama_pegawai; }
            set { nama_pegawai = value; }
        }

        public string Nohp
        {
            get { return nohp; }
            set { nohp = value; }
        }

        public PegawaiEntity(int id, string nama, string alamat, string email, string hp,int id_user) {
            Id_role = id;
            Nama_pegawai = nama;
            Alamat = alamat;
            Email = email;
            Nohp = hp;
            Id_login = id_user;
        }
        public PegawaiEntity(int id, string nama, string alamat, string email, string hp)
        {
            Id_role = id;
            Nama_pegawai = nama;
            Alamat = alamat;
            Email = email;
            Nohp = hp;
            
        }
    }
}
