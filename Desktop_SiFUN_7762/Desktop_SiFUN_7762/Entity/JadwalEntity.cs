using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_SiFUN_7762.Entity
{
    class JadwalEntity
    {
        int id_pegawai, id_kelas;

        public int Id_kelas
        {
            get { return id_kelas; }
            set { id_kelas = value; }
        }

        public int Id_pegawai
        {
            get { return id_pegawai; }
            set { id_pegawai = value; }
        }
        string hari;

        public string Hari
        {
            get { return hari; }
            set { hari = value; }
        }
        DateTime jam_mulai, jam_selesai;

        public DateTime Jam_selesai
        {
            get { return jam_selesai; }
            set { jam_selesai = value; }
        }

        public DateTime Jam_mulai
        {
            get { return jam_mulai; }
            set { jam_mulai = value; }
        }

        public JadwalEntity(int pegawai,int kelas, string hari, DateTime masuk, DateTime keluar) {
            Id_pegawai = pegawai;
            Id_kelas = kelas;
            Hari = hari;
            Jam_mulai = masuk;
            Jam_selesai = keluar;
        }
    }
}
