using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_SiFUN_7762.Entity
{
    class PromoEntity
    {
        string jenis_promo, keterangan, nama;

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string Jenis_promo
        {
            get { return jenis_promo; }
            set { jenis_promo = value; }
        }

        public string Keterangan
        {
            get { return keterangan; }
            set { keterangan = value; }
        }
        decimal harga;

        public decimal Harga
        {
            get { return harga; }
            set { harga = value; }
        }

        public PromoEntity(string jenis, decimal harga, string keterangan,string nama) {
            Jenis_promo = jenis;
            Keterangan = keterangan;
            Harga = harga;
            Nama = nama;
        }
    }
}
