using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Penggajian_Perusahaan
{
    public interface iKaryawan{
        string nama {get; set;}
        string StatusKaryawan {get; set;}
    }

    // abstraction
    public abstract class Karyawan:iKaryawan
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
