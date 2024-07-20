using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Penggajian_Perusahaan
{
    public class KaryawanTetap :Karyawan
    {
        public decimal Bonus { get; set; }

        // Override metode
        public override decimal KalkulasiGaji()
        {
            return BaseGaji + Bonus;
        }
    }
}
