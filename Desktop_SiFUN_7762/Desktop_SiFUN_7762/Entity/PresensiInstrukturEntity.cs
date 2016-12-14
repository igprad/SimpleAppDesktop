using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_SiFUN_7762.Entity
{
    class PresensiInstrukturEntity
    {
        int id_pegawai, id_jadwal;

        public int Id_jadwal
        {
            get { return id_jadwal; }
            set { id_jadwal = value; }
        }

        public int Id_pegawai
        {
            get { return id_pegawai; }
            set { id_pegawai = value; }
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

        public PresensiInstrukturEntity(int id_peg, int id_jad, DateTime datang, string ket) {
            Id_pegawai = id_peg;
            Id_jadwal = id_jad;
            Jam_kedatangan = datang;
            Keterangan = ket;
        }
    }
}
