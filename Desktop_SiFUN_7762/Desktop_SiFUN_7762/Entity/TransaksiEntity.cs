using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_SiFUN_7762.Entity
{
    class TransaksiEntity
    {
        int id_promo, id_member, id_Kelas;

        public int Id_member
        {
            get { return id_member; }
            set { id_member = value; }
        }

        public int Id_Kelas
        {
            get { return id_Kelas; }
            set { id_Kelas = value; }
        }

        public int Id_promo
        {
            get { return id_promo; }
            set { id_promo = value; }
        }
        DateTime tanggal;

        public DateTime Tanggal
        {
            get { return tanggal; }
            set { tanggal = value; }
        }
        double harga;

        public double Harga
        {
            get { return harga; }
            set { harga = value; }
        }

        public TransaksiEntity(int idPro,int idMem,int idKel,DateTime tgl, double total) {
            Id_promo = idPro;
            Id_member = idMem;
            Id_Kelas = idKel;
            Tanggal = tgl;
            Harga = total;
        }
    }
}
