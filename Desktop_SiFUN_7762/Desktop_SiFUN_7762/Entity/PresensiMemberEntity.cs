using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_SiFUN_7762.Entity
{
    class PresensiMemberEntity
    {
        int id_member, id_jadwal;

        public int Id_jadwal
        {
            get { return id_jadwal; }
            set { id_jadwal = value; }
        }

        public int Id_member
        {
            get { return id_member; }
            set { id_member = value; }
        }
        DateTime jam_kedatangan;

        public DateTime Jam_kedatangan
        {
            get { return jam_kedatangan; }
            set { jam_kedatangan = value; }
        }
        string keterangan;

        public string Keterangan
        {
            get { return keterangan; }
            set { keterangan = value; }
        }

        public PresensiMemberEntity(int id_member,DateTime jam,string ket,int id_jdwl) {
            Id_member = id_member;
            Jam_kedatangan = jam;
            Keterangan = ket;
            Id_jadwal = id_jdwl;
        }
    }
}
