using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2723
{
    

    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("NIK\tNama\t\t\tGaji Bulanan\n------------------------------");
           Karyawan karyawan = new Karyawan("12345", "Mega", 100000);
           karyawan.getKaryawan();
           Karyawan karyawan2 = new Karyawan("678910", "Dwirani", 150000);
           karyawan2.getKaryawan();
            Console.WriteLine("\n");
            Console.WriteLine("Asyiiiiikkkk Naik Gaji 10%");
            Console.WriteLine("\n");
            Console.WriteLine("NIK\tNama\t\t\tGaji Bulanan\n------------------------------");
            karyawan.NaikGaji();
            karyawan2.NaikGaji();


            Console.ReadKey();
        }
    }
}
