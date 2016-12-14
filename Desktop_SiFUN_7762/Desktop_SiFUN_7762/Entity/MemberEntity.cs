using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_SiFUN_7762.Entity
{
    class MemberEntity
    {
        int id_login;

        public int Id_login
        {
            get { return id_login; }
            set { id_login = value; }
        }
        string nama, alamat, email, status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

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

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        decimal deposit_uang;

        public decimal Deposit_uang
        {
            get { return deposit_uang; }
            set { deposit_uang = value; }
        }
        DateTime tgl_habis_aktif;

        public DateTime Tgl_habis_aktif
        {
            get { return tgl_habis_aktif; }
            set { tgl_habis_aktif = value; }
        }

        public MemberEntity(int id,string _nama,string alamat,string email,decimal deposit_uang,string status,DateTime tgl_hbs) {
            Id_login = id;
            Nama = _nama;
            Alamat = alamat;
            Email = email;
            Deposit_uang = deposit_uang;
            Status = status;
            Tgl_habis_aktif = tgl_hbs;
        }


    }
}
