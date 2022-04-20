using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4416
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Karyawan org1 = new Karyawan("190302123", "Rahman", 3000000);
            Karyawan org2 = new Karyawan("190302124", "Hakim", 2000000);
            Console.WriteLine("Program Gaji Bulanan Pt Artha Mulia Abadi");
            Console.WriteLine();
            Console.WriteLine("No      Nik/Nama            Gaji Bulanan");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1       {0}/{1}         {2}", org1.NIK, org1.Nama, org1.Gajian);
            Console.WriteLine("2       {0}/{1}          {2}", org2.NIK, org2.Nama, org2.Gajian);

            Console.WriteLine();
            Console.WriteLine("Berkah Ramadhan gaji naik 10%!");
            Console.WriteLine();

            org1.NaikkanGaji(10);
            org2.NaikkanGaji(10);

            Console.WriteLine("No      Nik/Nama            Gaji Bulanan");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1       {0}/{1}         {2}", org1.NIK, org1.Nama, org1.Gajian);
            Console.WriteLine("2       {0}/{1}          {2}", org2.NIK, org2.Nama, org2.Gajian);


            Console.ReadKey();

        }
    }
}
