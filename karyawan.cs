using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Penggajian_Perusahaan
{
    // abstraction
    public abstract class Karyawan
    {
        public string nama { get; set; }
        public string StatusKaryawan { get; set; }
        public decimal BaseGaji { get; set; }

        // method
        public virtual decimal KalkulasiGaji()
        {
            return BaseGaji;
        }
    }
}
