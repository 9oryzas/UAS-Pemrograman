using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistem_Penggajian_Perusahaan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input karyawan permanen dan kontrak
            KaryawanTetap permp = new KaryawanTetap { BaseGaji = 3000, Bonus = 1000 };
            anakIntern magang = new anakIntern { RateJam = 200, JamKerja = 8 };

            InputData bayar = new InputData();
            display itDept = new display { NamaDept = "IT" };

            Console.WriteLine("Masukkan Nama:");
            string x = Console.ReadLine();

            Console.WriteLine("\nStatus karyawan (tetap/intern):");
            string y = Console.ReadLine();
            Console.Clear();

            if (y == "tetap")
            {
                permp.nama = x;
                permp.StatusKaryawan = y;
                bayar.addKaryawan(permp);
                itDept.addKaryawan(permp);
            }
            else if (y == "intern")
            {
                magang.nama = x;
                magang.StatusKaryawan = y;
                bayar.addKaryawan(magang);
                itDept.addKaryawan(magang);
            }
            else
            {
                Console.WriteLine("Status karyawan tidak valid.");
                return;
            }

            bayar.displayTemp();

            Console.WriteLine("\n=============== Display =============\n");

            itDept.displayTemp();
        }
    }
}
