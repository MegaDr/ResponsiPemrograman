using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman
{
    class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public Karyawan(string nik, string nama, int gajibulanan)
        {
            Nik = nik;
            Nama = nama;
            GajiBulanan = gajibulanan;
            if (gajibulanan < 0)
            {
                GajiBulanan = 0;
            }

        }

        public void getKaryawan()
        {
            Console.WriteLine("{0}\t{1}\t\t\t{2}", Nik, Nama, GajiBulanan);
        }

        public void NaikGaji()
        {
            string Nik = this.Nik;
            string Nama = this.Nama;
            int GajiBulanan = this.GajiBulanan;

            int Bonus = GajiBulanan / 10;
            int KenaikanGaji = GajiBulanan + Bonus;
            if(GajiBulanan < 0)
            {
                Console.WriteLine("{0}\t{1}\t\t\t0", Nik, Nama);

            }

            else
            {
                Console.WriteLine("{0}\t{1}\t\t\t{2}", Nik, Nama, KenaikanGaji);
            }
        }
    }
}
