using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Penggajian_Perusahaan
{
    public class InputData
    {
        // Buat instance
        public List<Karyawan> Karyawann { get; set; } = new List<Karyawan>();

        // Method untuk menambahkan ke dalam daftar
        public void addKaryawan(Karyawan kryn)
        {
            Karyawann.Add(kryn);
        }

        public void displayTemp()
        {
            Console.WriteLine("=============== Input Data =============\n\n");

            foreach (var kryn in Karyawann)
            {
                Console.WriteLine($"Nama\t:{kryn.nama}\nStatus\t:{kryn.StatusKaryawan}\nGaji\t:{kryn.KalkulasiGaji():C}\n");
            }
        }
    }
}
