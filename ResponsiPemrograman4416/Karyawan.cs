using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4416
{
    internal class Karyawan
    {
        public string NIK { get; set; }
        public string Nama { get; set; }
        public float Gajian { get; set; }
        public Karyawan(string nik, string nama, float gaji)
        {
            NIK = nik;
            Nama = nama;
            if (gaji < 0)
            {
                gaji = 0;
            }
            Gajian = gaji;
        }

        public void NaikkanGaji(float persentase)
        {
            Gajian = persentase / 100 * Gajian + Gajian;
        }
    }
}
