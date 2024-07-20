using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Penggajian_Perusahaan
{
    public class display
    {
        public string NamaDept { get; set; }
        public List<Karyawan> Karyawann { get; set; } = new List<Karyawan>();

        public void addKaryawan(Karyawan kryn)
        {
            Karyawann.Add(kryn);
        }

        public void displayTemp()
        {
            foreach (var kryn in Karyawann)
            {
                Console.WriteLine($"Nama\t:{kryn.nama}\nStatus\t:{kryn.StatusKaryawan}\nGaji\t:{kryn.KalkulasiGaji():C}");
            }
            Console.WriteLine($"Depart\t:{NamaDept}\n\n\n");
        }
    }
}
