using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop_SiFUN_7762.Entity;
using Desktop_SiFUN_7762.db_sifunTableAdapters;
using System.Data;

namespace Desktop_SiFUN_7762.Control
{
    class PromoControl
    {
        TBL_PROMOTableAdapter tbl_promo = new TBL_PROMOTableAdapter();

        public DataTable TampilPromo() {
            return tbl_promo.GetData();
        }

        public void EntriPromo(string jenis,decimal harga,string keterangan,string nama) {
            tbl_promo.EntriPromo(jenis, harga, keterangan,nama);
        }

        public void EditPromo(string jenis, decimal harga, string keterangan, int id,string nama) {
            tbl_promo.EditPromo(jenis, harga, keterangan,nama,id);
        }

        public int CekPromoUnik(string jenis)
        {
            return (int)tbl_promo.CekPromoUnik(jenis);
        }
    }
}
