using System;

namespace ResponsiPemrograman3385
{
    class Karyawan
    {
        string nik { get; set; }
        string nama { get; set; }
        int gajibulanan { get; set; }

        public void infonama()
        {
            Console.Write(nama + "\t\t");
        }
        public void infonik()
        {
            Console.Write(nik + ' ');
        }
        public void infogajibulanan()
        {
            Console.Write(gajibulanan);
        }
        public int infogajibulanan2(int gajibulanan)
        {
            int hitung = 0;
            if (gajibulanan < 0)
            {
                hitung = 0;
            }
            else
            {
                hitung = gajibulanan * 10 / 100;
                hitung = hitung + gajibulanan;
            }

            return hitung;
        }



        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan();
            Karyawan karyawan2 = new Karyawan();

            karyawan1.nama = "Paijo";
            karyawan1.nik = "190302123";
            karyawan1.gajibulanan = 5000;

            karyawan2.nama = "Jono";
            karyawan2.nik = "190302124";
            karyawan2.gajibulanan = 10000;
            Console.WriteLine("Gaji yang belum dinaikkan");
            Console.WriteLine("No  Nik/Nama           Gaji Bulanan");
            Console.WriteLine("-----------------------------------");
            karyawan1.infonik();
            karyawan1.infonama();
            karyawan1.infogajibulanan();

            Console.WriteLine();
            karyawan2.infonik();
            karyawan2.infonama();
            karyawan2.infogajibulanan();

            Console.WriteLine("\n\nAlhamdulillah dapat kenaikan gaji");
            Console.WriteLine("\nNo  Nik/Nama           Gaji Bulanan");
            Console.WriteLine("-----------------------------------");
            karyawan1.infonik();
            karyawan1.infonama();
            Console.Write(karyawan1.infogajibulanan2(5000));

            Console.WriteLine();
            karyawan2.infonik();
            karyawan2.infonama();
            Console.Write(karyawan2.infogajibulanan2(10000));




            Console.ReadKey();
        }
    }
}