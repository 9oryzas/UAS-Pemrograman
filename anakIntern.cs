using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Penggajian_Perusahaan
{
    public class anakIntern :Karyawan
    {
        public decimal RateJam { get; set; }
        public int JamKerja { get; set; }

        // Override metode KalkulasiGaji
        public override decimal KalkulasiGaji()
        {
            return RateJam * JamKerja;
        }
    }
}
