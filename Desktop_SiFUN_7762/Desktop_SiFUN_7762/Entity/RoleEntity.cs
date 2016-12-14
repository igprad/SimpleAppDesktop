using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_SiFUN_7762.Entity
{
    class RoleEntity
    {
        string nama_role, keterangan;

        public string Keterangan
        {
            get { return keterangan; }
            set { keterangan = value; }
        }

        public string Nama_role
        {
            get { return nama_role; }
            set { nama_role = value; }
        }

        public RoleEntity(string nama, string ket) {
            Nama_role = nama;
            Keterangan = ket;
        }
    }
}
